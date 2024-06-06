using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// プレイヤーごとのデータを提供するインターフェース。
    /// </summary>
    public interface IPlayerData
    {
        /// <summary>
        /// プレイヤー名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 操作プレイヤーならtrue
        /// </summary>
        public bool IsLocalPlayer { get; }

        /// <summary>
        /// ローカルプレイヤーとして設定する。
        /// </summary>
        /// <param name="isLocalPlayer">trueならローカルプレイヤー。NPCにするならfalse</param>
        public void SetLocalPlayer(bool isLocalPlayer = true);
    }
}