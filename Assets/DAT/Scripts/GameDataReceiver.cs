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
        public abstract string GetJsonString();

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