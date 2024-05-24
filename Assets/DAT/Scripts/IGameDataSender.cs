namespace DAT
{
    /// <summary>
    /// データを送信するクラスのインターフェース。
    /// </summary>
    public interface IGameDataSender
    {
        /// <summary>
        /// 以前のデータを破棄して、新しいデータの作成を開始する。
        /// </summary>
        void DataBegin();

        /// <summary>
        /// バイトデータを設定する。
        /// </summary>
        /// <param name="value">設定したいバイトデータ</param>
        void SetByte(byte value);

        /// <summary>
        /// 4バイトデータを設定する。
        /// </summary>
        /// <param name="value">設定したい4バイトデータ</param>
        void SetInt(int value);

        /// <summary>
        /// 文字列データを設定する。
        /// </summary>
        /// <param name="value">設定したい文字列データ</param>
        void SetString(string value);

        /// <summary>
        /// 指定した相手に、設定したデータを送信する。
        /// 0=ホスト兼プレイヤー0。
        /// 1以上ならプレイヤー。
        /// -1なら全員。
        /// </summary>
        /// <param name="value">送信先を指定するためのインデックス。これ以外には、送信しない。相手を指定するのは、別のデータを送る。</param>
        void Send(int toIndex);
    }
}