using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    [Serializable]
    public class GameDataTest : GameDataCommand
    {
        public byte byteData;
        public int intData;
        public string stringData;
    }
}