using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    public class RecvFuncTest : IReceiveFunction
    {
        public void Process(IGameDataReceiver receiver, IBoard board)
        {
            Debug.Log($"GameDataTest.TryProcedure未実装");
        }
    }
}