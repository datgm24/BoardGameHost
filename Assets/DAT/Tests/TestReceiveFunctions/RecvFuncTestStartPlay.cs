using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// 操作開始を指示するコマンド。
    /// </summary>
    public class RecvFuncTestStartPlay : IReceiveFunction
    {
        public void Process(IGameDataReceiver receiver, IBoard board)
        {
            GameDataStartPlay data = JsonUtility.FromJson<GameDataStartPlay>(receiver.GetJsonString());
            if (data == null )
            {
                return;
            }

            var testBoard = board as TestBoard;
            testBoard.startPlayerIndex = data.startPlayerIndex;
            testBoard.turn = data.turn;
        }
    }
}