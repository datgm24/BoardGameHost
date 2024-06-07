using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DAT;
using NUnit.Framework.Constraints;

public class ReceiveCommandTests
{
    [Test]
    public void ReceiveCommandTestsSimplePasses()
    {
        // システムに必要なインスタンスを生成
        var sender = LocalGameDataSender.Instance;
        var receiver = LocalGameDataReceiver.Instance;

        // ボードを作成
        var board = new TestBoard();

        // コマンド実行の生成
        var commandInvoker = new CommandInvoker();
        commandInvoker.SetBoard(board);
        commandInvoker.SetReceiveFunction(CommandType.PlayersFromLobby, new RecvFuncTestPlayersFromLobby());
        commandInvoker.SetReceiveFunction(CommandType.Players, new RecvFuncTestPlayers());
        commandInvoker.SetReceiveFunction(CommandType.StartPlay, new RecvFuncTestStartPlay());
        commandInvoker.SetReceiveFunction(CommandType.Test, new RecvFuncTest());
        receiver.Register(commandInvoker);

        // ロビーから、プレイヤーデータを送信する。
        var playersFromLobby = new GameDataPlayers();
        playersFromLobby.names = new string[]
        {
            "ホストプレイヤー0",
            "プレイヤー1",
            "プレイヤー2",
        };
        playersFromLobby.nameIndex = 0;
        sender.Send(0, playersFromLobby);

        // プレイヤーが登録されたことを確認
        Assert.That(board.PlayerDataList.Count, Is.EqualTo(3), "3人登録");
        Assert.That(board.PlayerDataList[0].Name, Is.EqualTo("ホストプレイヤー0"), "Player0");
        Assert.That(board.PlayerDataList[1].Name, Is.EqualTo("プレイヤー1"), "Player1");
        Assert.That(board.PlayerDataList[2].Name, Is.EqualTo("プレイヤー2"), "Player2");
        Assert.That(board.LocalPlayerIndex, Is.EqualTo(0), "ローカルプレイヤー0");
        Assert.That(board.PlayerDataList[0].IsLocalPlayer, Is.True, "ローカルプレイヤー0");
        Assert.That(board.PlayerDataList[1].IsLocalPlayer, Is.False, "非ローカルプレイヤー1");
        Assert.That(board.PlayerDataList[2].IsLocalPlayer, Is.False, "非ローカルプレイヤー2");


        // 別のボードに、プレイヤー１をローカルプレイヤーとしてセットアップ
        var board1 = new TestBoard();

        // コマンド実行の生成
        var commandInvoker1 = new CommandInvoker();
        commandInvoker1.SetBoard(board1);
        commandInvoker1.SetReceiveFunction(CommandType.PlayersFromLobby, new RecvFuncTestPlayersFromLobby());
        commandInvoker1.SetReceiveFunction(CommandType.Players, new RecvFuncTestPlayers());
        commandInvoker1.SetReceiveFunction(CommandType.StartPlay, new RecvFuncTestStartPlay());
        commandInvoker1.SetReceiveFunction(CommandType.Test, new RecvFuncTest());
        receiver.Unregister(commandInvoker);    // 一つ目のボードを登録から外す
        receiver.Register(commandInvoker1);     // 二分目のボードへ送信

        // ロビーから、プレイヤーデータを送信する。
        playersFromLobby.nameIndex = 1;
        sender.Send(1, playersFromLobby);

        // プレイヤーが登録されたことを確認
        Assert.That(board1.PlayerDataList.Count, Is.EqualTo(3), "3人登録");
        Assert.That(board1.PlayerDataList[0].Name, Is.EqualTo("ホストプレイヤー0"), "Player0");
        Assert.That(board1.PlayerDataList[1].Name, Is.EqualTo("プレイヤー1"), "Player1");
        Assert.That(board1.PlayerDataList[2].Name, Is.EqualTo("プレイヤー2"), "Player2");
        Assert.That(board1.LocalPlayerIndex, Is.EqualTo(1), "ローカルプレイヤー1");
        Assert.That(board1.PlayerDataList[0].IsLocalPlayer, Is.False, "非ローカルプレイヤー0");
        Assert.That(board1.PlayerDataList[1].IsLocalPlayer, Is.True, "ローカルプレイヤー1");
        Assert.That(board1.PlayerDataList[2].IsLocalPlayer, Is.False, "非ローカルプレイヤー2");

        // ゲーム開始の調査
        Assert.That(board.startPlayerIndex, Is.EqualTo(-1), "ボード0startの処理前");
        Assert.That(board.turn, Is.EqualTo(-1), "ボード0turnの処理前");
        Assert.That(board1.startPlayerIndex, Is.EqualTo(-1), "ボード1startの処理前");
        Assert.That(board1.turn, Is.EqualTo(-1), "ボード1turnの処理前");

        receiver.Register(commandInvoker);
        var startData = new GameDataStartPlay(CommandType.StartPlay, 0, 0, 1);
        sender.Send(-1, startData);

        Assert.That(board.startPlayerIndex, Is.EqualTo(0), "ボード0startの処理前");
        Assert.That(board.turn, Is.EqualTo(1), "ボード0turnの処理前");
        Assert.That(board1.startPlayerIndex, Is.EqualTo(0), "ボード1startの処理前");
        Assert.That(board1.turn, Is.EqualTo(1), "ボード1turnの処理前");

    }

}
