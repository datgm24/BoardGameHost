using UnityEngine;

namespace DAT
{
    /// <summary>
    /// ホストから、プレイヤーへ、プレイヤーリストと、
    /// プレイヤーのインデックスを渡すデータと処理。
    /// </summary>
    public class GameDataTestPlayers : GameDataCommand, IReceiveFunction
    {
        /// <summary>
        /// 最初がホスト。以降、プレイ順。
        /// </summary>
        public string[] names;

        /// <summary>
        /// namesの中の自分のインデックス
        /// </summary>
        public int nameIndex;

        public bool TryProcedure(GameDataCommand data, IGameDataReceiver receiver, IBoard board)
        {
            Debug.Log($"未実装");
            return false;
        }
    }
}