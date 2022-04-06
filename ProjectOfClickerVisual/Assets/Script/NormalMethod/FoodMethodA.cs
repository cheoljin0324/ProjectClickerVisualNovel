using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FoodMethodA : MonoBehaviour
{
    [SerializeField]
    private Image imPactSprite;

    [SerializeField]
    private FoodManager foodManager;

    [SerializeField]
    private Sprite RamanSprite;
    [SerializeField]
    private Sprite TriangleSprite;
    [SerializeField]
    private Sprite DoshSprite;

    [SerializeField]
    private Button ramanButton;
    [SerializeField]
    private Button triangleButton;
    [SerializeField]
    private Button DoshiracButton;

    public void RamanBurf()
    {
        GameManager.Inst.isRaman = true;
        GameManager.Inst.RamanAmount -= 1;
        if (GameManager.Inst.RamanAmount == 0)
        {
            ramanButton.gameObject.SetActive(false);
        }
        StartCoroutine("RamanBurfIn");
    }

    IEnumerator RamanBurfIn()
    {

        imPactSprite.gameObject.SetActive(true);
        imPactSprite.sprite = RamanSprite;
        StartCoroutine("RamanAni");

        yield return new WaitForSeconds(30f);
        StopCoroutine("RamanAni");
        RamanStopRamanBurf();
    }

    IEnumerator RamanAni()
    {
        while (true)
        {
            imPactSprite.transform.DOScale(imPactSprite.transform.localScale * 1.2f, 2f);
            yield return new WaitForSeconds(1f);
            imPactSprite.transform.DOScale(imPactSprite.transform.localScale*0.8f, 2f);
            yield return new WaitForSeconds(1f);
        }

       
    }

    void RamanStopRamanBurf()
    {
        GameManager.Inst.isRaman = false;
        imPactSprite.gameObject.SetActive(false);
    }

    public void TriangleBurf()
    {
        GameManager.Inst.TriangleAmount -= 1;
        if (GameManager.Inst.TriangleAmount <= 0)
        {
            triangleButton.gameObject.SetActive(false);
        }
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
        imPactSprite.gameObject.SetActive(false);
    }

    public void DoshiBurf()
    {
        GameManager.Inst.DoshiAmount -= 1;
        if (GameManager.Inst.DoshiAmount <= 0)
        {
            DoshiracButton.gameObject.SetActive(false);
        }
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
