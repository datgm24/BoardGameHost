using UnityEngine.Events;

namespace DAT
{
    /// <summary>
    /// データを受信する機能を提供するインターフェース。
    /// </summary>
    public interface IGameDataReceiver
    {
        /// <summary>
        /// 受信したJson文字列を返す。
        /// </summary>
        string GetJsonString();

        /// <summary>
        /// 受信データの送り先を登録する。
        /// </summary>
        /// <param name="commandInvoker">受信データを送る先</param>
        void Register(ICommandInvoker commandInvoker);

        /// <summary>
        /// 受信データの送り先を解除する。
        /// </summary>
        /// <param name="commandInvoker">解除したいインスタンス</param>
        void Unregister(ICommandInvoker commandInvoker);
    }
}