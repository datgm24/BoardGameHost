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
        List<ICommandInvoker> commandInvokerList = new List<ICommandInvoker>();

        /// <summary>
        /// 受信したJSONの文字列。
        /// </summary>
        protected string jsonString;

        public void Register(ICommandInvoker commandInvoker)
        {
            commandInvokerList.Add(commandInvoker);
        }

        public void Unregister(ICommandInvoker commandInvoker)
        {
            commandInvokerList.Remove(commandInvoker);
        }

        /// <summary>
        /// jsonStringにデータを設定したら呼び出して、
        /// 登録されているCommandInvokerに受信データを渡す。
        /// </summary>
        protected void InvokeCommand()
        {
            for (int i = 0; i < commandInvokerList.Count; i++)
            {
                commandInvokerList[i].Receive(this);
            }
        }

        public string GetJsonString()
        {
            return jsonString;
        }
    }
}