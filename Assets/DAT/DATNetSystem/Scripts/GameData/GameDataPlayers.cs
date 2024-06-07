using System;
using UnityEngine;

namespace DAT
{
    [Serializable]
    /// <summary>
    /// ホストから、プレイヤーへ、プレイヤーリストと、
    /// プレイヤーのインデックスを渡すデータと処理。
    /// </summary>
    public class GameDataPlayers : GameDataCommand
    {
        /// <summary>
        /// 最初がホスト。以降、プレイ順。
        /// </summary>
        public string[] names;

        /// <summary>
        /// namesの中の自分のインデックス
        /// </summary>
        public int nameIndex;
    }
}