using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DAT
{
    /// <summary>
    /// データを受信したときに実行するコマンドを
    /// </summary>
    public interface ICommandInvoker
    {
        /// <summary>
        /// 受信したデータを受け取るためのメソッド。
        /// これを、GameDataReceiverへ登録する。
        /// </summary>
        /// <param name="receiver">レシーバーのインスタンス</param>
        void Receive(IGameDataReceiver receiver);

        /// <summary>
        /// コマンドを指定して、処理用のクラスを登録する。
        /// 同じコマンドにすでにクラスが登録されていたら、それらを削除して、
        /// 新しいものを登録する。
        /// </summary>
        /// <param name="command">対応するコマンド</param>
        /// <param name="receiveFunction">該当コマンドを処理するメソッドを持ったインスタンス</param>
        void SetReceiveFunction(CommandType command, IReceiveFunction receiveFunction);

        /// <summary>
        /// ボードを登録する。
        /// </summary>
        /// <param name="board">担当するボードのインスタンス</param>
        void SetBoard(IBoard board);
    }
}