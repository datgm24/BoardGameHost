using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DAT;

public class SendReceiveTests
{
    [Test]
    public void SendReceiveTestsSimplePasses()
    {
        Assert.IsNotNull(LocalGameDataReceiver.Instance);
        Assert.IsNotNull(LocalGameDataSender.Instance);

        Assert.AreNotEqual(LocalGameDataReceiver.Instance, PhotonGameDataReceiver.Instance);

        // ローカルの番号を指定
        var receiver = LocalGameDataReceiver.Instance as GameDataReceiver;
        var sender = LocalGameDataSender.Instance as GameDataSender;
        receiver.SetIndex(0);

        // 全員にデータを送信
        var data = new GameDataTest();
        data.command = 1;
        data.byteData = 1;
        data.intData = 2;
        data.stringData = "test";
        sender.Send(-1, data);

        // 送られてきたデータを受信してみる
        var recvData = JsonUtility.FromJson<GameDataTest>(receiver.GetJsonString());
        Assert.That(recvData.byteData, Is.EqualTo(1));
        Assert.That(recvData.intData, Is.EqualTo(2));
        Assert.That(recvData.stringData, Is.EqualTo("test"));

        // コマンドの取り出し確認
        var command = JsonUtility.FromJson<GameDataCommand>(receiver.GetJsonString());
        Assert.That(command.command, Is.EqualTo(1));
        Assert.That(command.to, Is.EqualTo(-1));

        // 特定の相手にデータを送信
        data.command = 2;
        data.byteData = 3;
        data.intData = 4;
        data.stringData = "test2";
        sender.Send(0, data);

        // 送られてきたデータを受信してみる
        recvData = JsonUtility.FromJson<GameDataTest>(receiver.GetJsonString());
        Assert.That(recvData.byteData, Is.EqualTo(3));
        Assert.That(recvData.intData, Is.EqualTo(4));
        Assert.That(recvData.stringData, Is.EqualTo("test2"));
        Assert.That(recvData.command, Is.EqualTo(2));
        Assert.That(recvData.to, Is.EqualTo(0));

        // 違う宛先へ送信
        data.command = 3;
        data.byteData = 1;
        sender.Send(1,data);

        // 送られてきたデータを受信してみる
        recvData = JsonUtility.FromJson<GameDataTest>(receiver.GetJsonString());
        Assert.That(recvData.command, Is.Not.EqualTo(3));
    }
}
