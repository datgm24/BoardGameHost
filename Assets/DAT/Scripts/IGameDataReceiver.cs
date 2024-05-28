using UnityEngine.Events;

namespace DAT
{
    /// <summary>
    /// データを受信する機能を提供するインターフェース。
    /// </summary>
    public interface IGameDataReceiver
    {
        /// <summary>
        /// 受信データを処理する機能を登録する。
        /// </summary>
        /// <param name="receiveFunction">登録したい機能のインスタンス</param>
        void Register(IReceiveFunction receiveFunction);

        /// <summary>
        /// 受信データを処理する機能の登録を解除する。
        /// </summary>
        /// <param name="receiveFunction">解除したい機能のインスタンス</param>
        void Unregister(IReceiveFunction receiveFunction);

        /// <summary>
        /// 受信したJSON文字列を返す。
        /// </summary>
        /// <returns>JSON文字列</returns>
        string GetJsonString();
    }
}