using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    public interface IBoard
    {
        /// <summary>
        /// このボードのプレイヤーのインデックスを返す。
        /// </summary>
        int LocalPlayerIndex => -1;

        /// <summary>
        /// デバッグ用に、ロビーから送られてくるプレイヤーリストの
        /// 処理を無視したい場合、trueにする。
        /// </summary>
        bool IgnoreLobbyData => false;

        /// <summary>
        /// プレイヤーデータのリスト
        /// </summary>
        List<IPlayerData> PlayerDataList { get; }

        /// <summary>
        /// プレイヤー名からプレイヤーを生成する。
        /// </summary>
        /// <param name="playerNames">登録したいプレイヤー名の配列</param>
        void EntryPlayers(string[] playerNames);

        /// <summary>
        /// プレイヤーインデックスを設定する。
        /// </summary>
        /// <param name="index"></param>
        void SetLocalPlayerIndex(int index);

        /// <summary>
        /// ロビーデータを無視するフラグの設定。
        /// </summary>
        /// <param name="flag">無視させるとき、trueか省略。</param>
        void SetIgnoreLobbyData(bool flag = true);
    }
}