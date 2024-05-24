using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAT
{
    public class LocalGameDataReceiver : GameDataReceiver, IGameDataReceiver
    {
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

        public override byte GetByte()
        {
            return 0;
        }

        public override int GetInt()
        {
            return 0;
        }

        public override string GetString()
        {
            return "";
        }
    }
}