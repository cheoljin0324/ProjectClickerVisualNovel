using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShop : MonoBehaviour
{
    private int pianoMoney = 1;
    private int micMoney = 1;
    private int drumMoney = 1;

   public void PianoUpdate()
    {
        GameManager.Inst.PianoLevel += 1;
        GameManager.Inst.plCoin -= pianoMoney;
        pianoMoney = (GameManager.Inst.PianoLevel * GameManager.Inst.PianoLevel * 2) + 1;
        GameManager.Inst.SaveData();
    }
    public void MicUpdate()
    {
        GameManager.Inst.MicLevel += 1;
        GameManager.Inst.plCoin -= micMoney;
        micMoney = (GameManager.Inst.MicLevel * GameManager.Inst.MicLevel * 2) + 1;
        GameManager.Inst.SaveData();
    }

    public void DrumUpdate()
    {
        GameManager.Inst.DrumLevel += 1;
        GameManager.Inst.plCoin -= drumMoney;
        drumMoney = (GameManager.Inst.DrumLevel * GameManager.Inst.DrumLevel * 2) + 1;
        GameManager.Inst.SaveData();
    }
}
