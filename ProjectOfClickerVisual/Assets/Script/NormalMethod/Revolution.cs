using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Revolution : MonoBehaviour
{

    [SerializeField]
    private Button revolButton;

    public void RevolSet()
    {
        if (GameManager.Inst.Rpc > 100000)
        {
            revolButton.image.color = new Color(1, 1, 1, 0.5f);
            GameManager.Inst.levolutionStack++;
            GameManager.Inst.SaveData();
            SetData();
        }

    }

    public void Update()
    {
        if(GameManager.Inst.Rpc > 100000)
        {
            revolButton.image.color = new Color(1, 1, 1, 1);
        }
    }

    public void SetData()
    {
        GameManager.Inst.RevolutionNum = (GameManager.Inst.RpcLevel1 / 10) + (GameManager.Inst.RpcLevel2 / 10) + (GameManager.Inst.RpcLevel3 / 10) + (GameManager.Inst.RpcLevel4 / 10) + (GameManager.Inst.RpcLevel5 / 10) + (GameManager.Inst.RpcLevel6 / 10) + (GameManager.Inst.RpcLevel7 / 10) + (GameManager.Inst.RpcLevel8 / 10) + (GameManager.Inst.RpcLevel9 / 10) + (GameManager.Inst.RpcLevel10 / 10);
        GameManager.Inst.RpcLevel1 = 21;
        GameManager.Inst.RpcLevel2 = 21;
        GameManager.Inst.RpcLevel3 = 21;
        GameManager.Inst.RpcLevel4 = 21;
        GameManager.Inst.RpcLevel5 = 21;
        GameManager.Inst.RpcLevel6 = 21;
        GameManager.Inst.RpcLevel7 = 21;
        GameManager.Inst.RpcLevel8 = 21;
        GameManager.Inst.RpcLevel9 = 21;
        GameManager.Inst.RpcLevel10 = 21;

        GameManager.Inst.SaveData();
        GameManager.Inst.LoadData();
    }

}
