namespace DAT
{
    public interface IReceiveFunction
    {
        /// <summary>
        /// 渡された、IGameDataReceiverのメソッドを使ってデータを取り出して、
        /// 対応コマンドかを調べて、そうであれば、さらにデータを取り出して処理をする。
        /// 自分が、データを処理したら、trueを返す。
        /// </summary>
        /// <param name="data">受信データのコマンド</param>
        /// <param name="receiver">受信インスタンス</param>
        /// <param name="board">担当するボードのインスタンス</param>
        /// <returns>自分が処理したら、true。何もせずに次に渡すならfalse</returns>
        bool TryProcedure(GameDataCommand data, IGameDataReceiver receiver, IBoard board);
    }
}
