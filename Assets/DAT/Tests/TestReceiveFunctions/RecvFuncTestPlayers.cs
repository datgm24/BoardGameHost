using UnityEngine;

namespace DAT
{
    /// <summary>
    /// ホストから、プレイヤーへ、プレイヤーリストと、
    /// プレイヤーのインデックスを渡すデータと処理。
    /// </summary>
    public class RecvFuncTestPlayers : IReceiveFunction
    {
        public void Process(IGameDataReceiver receiver, IBoard board)
        {
            Debug.Log($"RecvFuncTestPlayers 未実装");
        }
    }
}