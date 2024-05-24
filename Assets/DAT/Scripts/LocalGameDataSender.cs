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

        public override void DataBegin()
        {
            Debug.Log($"未実装");
        }

        public override void Send(int toIndex)
        {
            Debug.Log($"未実装");
        }

        public override void SetByte(byte value)
        {
            Debug.Log($"未実装");
        }

        public override void SetInt(int value)
        {
            Debug.Log($"未実装");
        }

        public override void SetString(string value)
        {
            Debug.Log($"未実装");
        }
    }
}