using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        /// コマンドのインスタンスを受け取る。
        /// </summary>
        /// <param name="receiveFunctions">コマンドの配列</param>
        void SetReceiveFunctions(IReceiveFunction[] receiveFunctions);

        /// <summary>
        /// ボードを登録する。
        /// </summary>
        /// <param name="board">担当するボードのインスタンス</param>
        void SetBoard(IBoard board);
    }
}