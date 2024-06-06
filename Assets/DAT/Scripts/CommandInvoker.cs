using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// 受信したデータを処理するコマンドと担当するボードを登録して、
    /// データを受信したら、コマンドを呼び出すクラス。
    /// </summary>
    public class CommandInvoker : ICommandInvoker
    {
        IBoard boardInstance;
        IReceiveFunction []functions;

        public void Receive(IGameDataReceiver receiver)
        {
            var command = JsonUtility.FromJson<GameDataCommand>(receiver.GetJsonString());
            if (command == null )
            {
                return;
            }

            for (int i = 0; i < functions.Length; i++)
            {
                if ((functions[i] != null)
                    && functions[i].TryProcedure(command, receiver, boardInstance))
                {
                    // 実行できたらここで終了
                    return;
                }
            }
        }

        public void SetBoard(IBoard board)
        {
            boardInstance = board;
        }

        public void SetReceiveFunctions(IReceiveFunction[] receiveFunctions)
        {
            functions = receiveFunctions;
        }
    }
}