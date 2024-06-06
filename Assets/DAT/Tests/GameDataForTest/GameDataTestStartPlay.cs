using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// 操作開始を指示するコマンド。
    /// </summary>
    public class GameDataTestStartPlay : GameDataCommand, IReceiveFunction
    {
        /// <summary>
        /// 開始するプレイヤーのインデックス
        /// </summary>
        public int startPlayerIndex;

        public bool TryProcedure(GameDataCommand data, IGameDataReceiver receiver, IBoard board)
        {
            Debug.Log($"未実装");
            return false;
        }
    }
}