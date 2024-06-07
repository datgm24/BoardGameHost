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

        /// <summary>
        /// ターン数
        /// </summary>
        public int turn;

        public GameDataStartPlay(CommandType commandType, int sendTo, int player, int setTurn)
        {
            command = (byte)commandType;
            to = (short)sendTo;
            startPlayerIndex = player;
            turn = setTurn;
        }
    }
}