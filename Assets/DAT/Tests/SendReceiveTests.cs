using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DAT;

public class SendReceiveTests
{
    [Test]
    public void SendReceiveTestsSimplePasses()
    {
        Assert.IsNotNull(LocalGameDataReceiver.Instance);
        Assert.IsNotNull(LocalGameDataSender.Instance);

        Assert.AreNotEqual(LocalGameDataReceiver.Instance, PhotonGameDataReceiver.Instance);

        // ローカルの番号を指定
        LocalGameDataReceiver.Instance.SetIndex(0);

        // 全員にデータを送信
        LocalGameDataSender.Instance.DataBegin();
        LocalGameDataSender.Instance.SetByte(1);
        LocalGameDataSender.Instance.SetInt(2);
        LocalGameDataSender.Instance.SetString("test");
        LocalGameDataSender.Instance.Send(-1);

        // 送られてきたデータを受信してみる
        Assert.That(LocalGameDataReceiver.Instance.GetByte(), Is.EqualTo(1));
        Assert.That(LocalGameDataReceiver.Instance.GetInt(), Is.EqualTo(2));
        Assert.That(LocalGameDataReceiver.Instance.GetString(), Is.EqualTo("test"));
        Assert.That(LocalGameDataReceiver.Instance.GetByte(), Is.EqualTo(0));

        // 特定の相手にデータを送信
        LocalGameDataSender.Instance.DataBegin();
        LocalGameDataSender.Instance.SetByte(3);
        LocalGameDataSender.Instance.SetInt(4);
        LocalGameDataSender.Instance.SetString("test2");
        LocalGameDataSender.Instance.Send(0);

        // 送られてきたデータを受信してみる
        Assert.That(LocalGameDataReceiver.Instance.GetByte(), Is.EqualTo(3));
        Assert.That(LocalGameDataReceiver.Instance.GetInt(), Is.EqualTo(4));
        Assert.That(LocalGameDataReceiver.Instance.GetString(), Is.EqualTo("test2"));
        Assert.That(LocalGameDataReceiver.Instance.GetByte(), Is.EqualTo(0));

        // 違う宛先へ送信
        LocalGameDataSender.Instance.DataBegin();
        LocalGameDataSender.Instance.SetByte(1);
        LocalGameDataSender.Instance.Send(1);

        // 送られてきたデータを受信してみる
        Assert.That(LocalGameDataReceiver.Instance.GetByte(), Is.EqualTo(0));
    }
}
