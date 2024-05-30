using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// ローカルPC内で、疑似的に通信してみせるクラス。
    /// </summary>
    public class LocalGameDataSender : GameDataSender, IGameDataSender
    {
        static LocalGameDataSender instance;

        /// <summary>
        /// インスタンス。参照前に、New<T>()で生成が必要。
        /// </summary>
        public static LocalGameDataSender Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LocalGameDataSender();
                }
                return instance;
            }
        }

        /// <summary>
        /// デバッグ用に、シングルトンのインスタンスをクリアするメソッド。
        /// </summary>
        public static void ClearInstance()
        {
            instance = null;
        }

        public override void Send<T>(int toIndex, T data)
        {
            data.to = (short)toIndex;
            LocalGameDataReceiver.Instance.SetJson(JsonUtility.ToJson(data));
        }
    }
}