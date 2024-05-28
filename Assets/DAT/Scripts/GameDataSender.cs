namespace DAT
{
    /// <summary>
    /// データを送信するクラスのベースクラス。
    /// 使用する前に、New<T>()で、インスタンスを生成する。
    /// </summary>
    public abstract class GameDataSender : IGameDataSender
    {
        public abstract void Send(int toIndex, string json);
    }
}
