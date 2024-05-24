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
        /// 受信したデータから1バイト取り出して、返す。
        /// 読み取り場所を、1バイト進めておく。
        /// </summary>
        /// <returns>1バイト読み取って返す。読めない場合は0</returns>
        byte GetByte();

        /// <summary>
        /// 受信したデータから4バイト取り出して、返す。
        /// 読み取り場所を、4バイト進めておく。
        /// </summary>
        /// <returns>4バイト読み取って返す。読めない場合は0</returns>
        int GetInt();

        /// <summary>
        /// 受信したデータから文字列を1つ取り出して、返す。
        /// 読み取った分、読み取り位置を進めておく。
        /// </summary>
        /// <returns></returns>
        string GetString();
    }
}