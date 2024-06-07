using UnityEngine;

namespace DAT
{
    /// <summary>
    /// ロビーから送られてくるローカルプレイヤーのインデックスと、プレイヤー名リストを処理。
    /// </summary>
    public class RecvFuncTestPlayers : IReceiveFunction
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