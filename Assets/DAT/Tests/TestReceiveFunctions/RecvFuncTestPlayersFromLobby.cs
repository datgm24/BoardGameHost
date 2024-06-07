using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// ロビーからプレイヤーリストを送るデータ。
    /// </summary>
    public class RecvFuncTestPlayersFromLobby : IReceiveFunction
    {
        public void Process(IGameDataReceiver receiver, IBoard board)
        {
            GameDataPlayers recv = JsonUtility.FromJson<GameDataPlayers>(receiver.GetJsonString());
            if (recv == null)
            {
                // 変換失敗
                return;
            }

            board.EntryPlayers(recv.names);
            board.SetLocalPlayerIndex(recv.nameIndex);
        }
    }
}