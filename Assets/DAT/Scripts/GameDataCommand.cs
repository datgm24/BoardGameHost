using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    [Serializable]
    public class GameDataCommand
    {
        /// <summary>
        /// コマンド
        /// </summary>
        public byte command;
        /// <summary>
        /// 宛先
        /// </summary>
        public short to;
    }
}