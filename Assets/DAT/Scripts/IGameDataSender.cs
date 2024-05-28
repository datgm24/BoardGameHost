namespace DAT
{
    /// <summary>
    /// データを送信するクラスのインターフェース。
    /// </summary>
    public interface IGameDataSender
    {
        /// <summary>
        /// 指定した相手に、設定したデータを送信する。
        /// 0=ホスト兼プレイヤー0。
        /// 1以上ならプレイヤー。
        /// -1なら全員。
        /// </summary>
        /// <param name="toIndex">送信先を指定するためのインデックス。これ以外には、送信しない。相手を指定するのは、別のデータを送る。</param>
        /// <param name="json">送信するデータのJSON</param>
        void Send(int toIndex, string json);
    }
}