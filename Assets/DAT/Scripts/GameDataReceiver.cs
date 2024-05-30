using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// データ受信クラスのベースクラス。
    /// インスタンスの提供と、処理機能の登録処理を提供。
    /// 抽象クラス<>具象クラス
    /// </summary>
    public abstract class GameDataReceiver : IGameDataReceiver
    {
        public string GetJsonString() => jsonString;

        /// <summary>
        /// 受信したJSONの文字列。
        /// </summary>
        protected string jsonString;

        /// <summary>
        /// 自分を特定するインデックス値。ホストから送られてきたデータを記録。
        /// 自分宛てのデータかをこれで確認して、違えば受け取らないようにする。
        /// </summary>
        public int MyIndex { get; private set; }

        /// <summary>
        /// MyIndexを設定するためのメソッド。
        /// </summary>
        /// <param name="index">設定したいインデックス</param>
        public void SetIndex(int index)
        {
            MyIndex = index;
        }

        public void Register(IReceiveFunction receiveFunction)
        {
            Debug.Log("未実装");
        }

        public void Unregister(IReceiveFunction receiveFunction)
        {
            Debug.Log("未実装");
        }
    }
}