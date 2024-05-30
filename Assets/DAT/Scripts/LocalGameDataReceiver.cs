using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    public class LocalGameDataReceiver : GameDataReceiver, IGameDataReceiver
    {
        static LocalGameDataReceiver instance;

        /// <summary>
        /// インスタンス。参照前に、New<T>()で生成が必要。
        /// </summary>
        public static LocalGameDataReceiver Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LocalGameDataReceiver();
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

        /// <summary>
        /// 受け取ったJSON文字列を保存する。
        /// </summary>
        /// <param name="json">JSON文字列</param>
        public void SetJson(string json)
        {
            var command = JsonUtility.FromJson<GameDataCommand>(json);
            if (command == null)
            {
                return;
            }

            // 宛先が全員(-1)、あるいは、自分宛てのとき、データを記録
            if ((command.to == -1) || (command.to == MyIndex))
            {
                jsonString = json;
            }
        }
    }
}