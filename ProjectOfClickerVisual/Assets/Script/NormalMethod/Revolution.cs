using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    
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
    }

}
