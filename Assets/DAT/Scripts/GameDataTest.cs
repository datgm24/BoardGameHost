using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    [Serializable]
    public class GameDataTest : GameDataCommand, IReceiveFunction
    {
        public byte byteData;
        public int intData;
        public string stringData;

        public bool TryProcedure(GameDataCommand data, IGameDataReceiver receiver, IBoard board)
        {
            Debug.Log($"GameDataTest.TryProcedure未実装");
            return false;
        }
    }
}