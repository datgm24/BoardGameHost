using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    [Serializable]
    /// <summary>
    /// 操作開始を指示するコマンド。
    /// </summary>
    public class GameDataStartPlay : GameDataCommand
    {
        /// <summary>
        /// 開始するプレイヤーのインデックス
        /// </summary>
        public int startPlayerIndex;
    }
}