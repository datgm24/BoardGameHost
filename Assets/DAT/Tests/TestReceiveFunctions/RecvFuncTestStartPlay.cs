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
            Debug.Log($"RecvFuncTestStartPlay 未実装");
        }
    }
}