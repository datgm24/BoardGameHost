using System.Collections.Generic;

namespace DAT
{
    public class TestBoard : BoardBase, IBoard
    {
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