using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    public class ReceiveFunctionPlayers : IReceiveFunction
    {
        public void Process(IGameDataReceiver receiver, IBoard board)
        {
            Debug.Log($"ReceiveFunctionPlayers 未実装");
        }
    }
}