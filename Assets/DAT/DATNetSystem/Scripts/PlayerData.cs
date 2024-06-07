using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// プレイヤーの管理データ
    /// </summary>
    public class PlayerData : IPlayerData
    {
        public string Name { get; private set; }

        public bool IsLocalPlayer { get; private set; }

        public void SetLocalPlayer(bool isLocalPlayer = true)
        {
            IsLocalPlayer = isLocalPlayer;
        }

        /// <summary>
        /// プレイヤー名を設定する。
        /// </summary>
        /// <param name="playerName">プレイヤー名</param>
        public void SetName(string playerName)
        {
            Name = playerName;
        }
    }
}