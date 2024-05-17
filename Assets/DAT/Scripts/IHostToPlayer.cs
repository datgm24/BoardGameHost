using UnityEngine.Events;

namespace DAT
{
    public interface IHostToPlayer
    {
        /// <summary>
        /// 指定したプレイヤーに、通知を送信する。
        /// TODO: 引数を決める。
        /// </summary>
        void Send();

        /// <summary>
        /// 全プレイヤーに、通知を送信する。
        /// TODO: 引数を決める。
        /// </summary>
        void SendAll();

        /// <summary>
        /// データを受信したときに、データを渡して実行する処理を登録する。
        /// TODO: データの送り方を決める。
        /// </summary>
        UnityEvent DataRecieved { get; }
    }
}