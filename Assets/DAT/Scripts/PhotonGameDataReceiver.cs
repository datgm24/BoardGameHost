using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    /// <summary>
    /// Photon Realtime用のデータ受信クラス。
    /// </summary>
    public class PhotonGameDataReceiver : GameDataReceiver, IGameDataReceiver
    {
        static IGameDataReceiver instance;

        /// <summary>
        /// インスタンス。参照前に、New<T>()で生成が必要。
        /// </summary>
        public static IGameDataReceiver Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhotonGameDataReceiver();
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

        public override string GetJsonString()
        {
            return "";
        }
    }
}