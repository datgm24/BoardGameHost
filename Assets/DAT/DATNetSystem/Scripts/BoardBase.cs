using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// ボードのベースクラス。
    /// </summary>
    public abstract class BoardBase : IBoard
    {
        public int LocalPlayerIndex { get; protected set; }
        public bool IgnoreLobbyData { get; protected set; }

        protected List<IPlayerData> playerDataList = new List<IPlayerData>();
        public List<IPlayerData> PlayerDataList { get { return playerDataList; } }

        public abstract void EntryPlayers(string[] playerNames);

        public void SetLocalPlayerIndex(int index)
        {
            LocalPlayerIndex = index;
            for (int i=0;i<PlayerDataList.Count;i++)
            {
                PlayerDataList[i].SetLocalPlayer(i == index);
            }
        }

        public void SetIgnoreLobbyData(bool flag = true)
        {
            IgnoreLobbyData = flag;
        }
    }
}