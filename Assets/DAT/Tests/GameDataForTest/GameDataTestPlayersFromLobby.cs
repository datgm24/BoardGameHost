using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// ロビーから、ホストへ、プレイヤーリストを送るデータと処理のテスト用のクラス。
    /// </summary>
    public class GameDataTestPlayersFromLobby : GameDataCommand, IReceiveFunction
    {
        public GameDataTestPlayersFromLobby()
        {
            command = (byte)CommandType.PlayersFromLobby;
        }

        /// <summary>
        /// プレイヤー名のリスト
        /// </summary>
        public string[] names;

        public bool TryProcedure(GameDataCommand data, IGameDataReceiver receiver, IBoard board)
        {
            if (data.command != command)
            {
                return false;
            }

            GameDataPlayersFromLobby recv = JsonUtility.FromJson<GameDataPlayersFromLobby>(receiver.GetJsonString());
            if (recv == null)
            {
                // 変換失敗
                return false;
            }

            // ロビーデータを無視するフラグが有効なら、何もしない
            if (board.IgnoreLobbyData)
            {
                return true;
            }

            board.EntryPlayers(recv.names);
            board.SetLocalPlayerIndex(0);
            return true;
        }
    }
}