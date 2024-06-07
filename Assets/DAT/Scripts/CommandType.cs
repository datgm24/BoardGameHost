namespace DAT
{
    /// <summary>
    /// 公開列挙子。コマンドの種類を定義する。
    /// </summary>
    public enum CommandType
    {
        None = -1,
        Players,            // ロビーからプレイヤーリストの送信
        StartPlay,          // ゲームの開始指示
        Test,               // テストデータ
    }
}