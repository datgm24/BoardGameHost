using System.Collections.Generic;

namespace DAT
{
    public class TestBoard : BoardBase, IBoard
    {
        /// <summary>
        /// 開始するプレイヤーのインデックス
        /// </summary>
        public int startPlayerIndex = -1;

        /// <summary>
        /// ターン数
        /// </summary>
        public int turn = -1;

        public override void EntryPlayers(string[] playerNames)
        {
            playerDataList.Clear();
            for (int i = 0; i < playerNames.Length; i++)
            {
                var playData = new PlayerData();
                playData.SetName(playerNames[i]);
                playerDataList.Add(playData);
            }
        }
    }
}