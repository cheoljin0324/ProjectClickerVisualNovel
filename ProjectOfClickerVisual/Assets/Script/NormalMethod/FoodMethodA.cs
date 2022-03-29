using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMethodA : MonoBehaviour
{
    public void RamanBurf()
    {
        GameManager.Inst.Rps=GameManager.Inst.Rps * 10;
        GameManager.Inst.RamanAmount -= 1;
        StartCoroutine("RamanBurfIn");
    }

    IEnumerator RamanBurfIn()
    {
        yield return new WaitForSeconds(30f);
        StopRamanBurf();


    }

    void StopRamanBurf()
    {
        GameManager.Inst.Rps = GameManager.Inst.Rps * 10;
    }
}
