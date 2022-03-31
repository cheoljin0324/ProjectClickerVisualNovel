using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMethodA : MonoBehaviour
{
    public void RamanBurf()
    {
        GameManager.Inst.isRaman = true;
        StartCoroutine("RamanBurfIn");
    }

    IEnumerator RamanBurfIn()
    {
        yield return new WaitForSeconds(30f);
        RamanStopRamanBurf();
    }

    void RamanStopRamanBurf()
    {
        GameManager.Inst.isRaman = false;
    }

    public void TriangleBurf()
    {
        GameManager.Inst.isTriangle = true;
        StartCoroutine(TriangleBurfIn());
    }

    IEnumerator TriangleBurfIn()
    {
        yield return new WaitForSeconds(30f);
        RamanStopRamanBurf();
    }

    public void TriangleCoroutineStop()
    {
        GameManager.Inst.isTriangle = false;
    }

    public void DoshiBurf()
    {
        GameManager.Inst.isDosh = true;

    }
    IEnumerator DoshBurfIn()
    {
        yield return new WaitForSeconds(30f);
        DoshCoroutineStop();
    }
    public void DoshCoroutineStop()
    {
        GameManager.Inst.isDosh = false;
    }
}
