using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// ロビーから、ホストへ、プレイヤーリストを送るデータと処理。
    /// </summary>
    public class GameDataPlayersFromLobby : GameDataCommand, IReceiveFunction
    {
        /// <summary>
        /// プレイヤー名のリスト
        /// </summary>
        public string[] names;

        public bool TryProcedure(GameDataCommand data, IGameDataReceiver receiver, IBoard board)
        {
            Debug.Log($"未実装");
            return false;
        }
    }
}