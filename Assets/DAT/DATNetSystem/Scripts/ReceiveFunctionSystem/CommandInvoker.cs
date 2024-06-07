using GluonGui.Dialog;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DAT
{
    /// <summary>
    /// 受信したデータを処理するコマンドと担当するボードを登録して、
    /// データを受信したら、コマンドを呼び出すクラス。
    /// </summary>
    public class CommandInvoker : ICommandInvoker
    {
        IBoard boardInstance;
        Dictionary<CommandType, IReceiveFunction> functions = new();

        public void Receive(IGameDataReceiver receiver)
        {
            var command = JsonUtility.FromJson<GameDataCommand>(receiver.GetJsonString());
            if (command == null )
            {
                return;
            }

            if (Enum.TryParse($"{command.command}", false, out CommandType comm))
            {
                if (functions.ContainsKey(comm))
                {
                    functions[comm]?.Process(receiver, boardInstance);
                }
            }
        }

        public void SetBoard(IBoard board)
        {
            boardInstance = board;
        }

        public void SetReceiveFunction(CommandType command, IReceiveFunction receiveFunction)
        {
            functions[command] = receiveFunction;
        }
    }
}