using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FoodMethodA : MonoBehaviour
{

    [SerializeField]
    private FoodManager foodManager;

    [SerializeField]
    private GameObject ramanParticle;
    [SerializeField]
    private GameObject TriangleParticle;
    [SerializeField]
    private GameObject DoshParticle;

    [SerializeField]
    public Button ramanButton;
    [SerializeField]
    public Button triangleButton;
    [SerializeField]
    public Button DoshiracButton;

    [SerializeField]
    private Image ramanImage;
    [SerializeField]
    private Image triangleImage;
    [SerializeField]
    private Image DoshiracImage;

    bool imageTrue = false;
    private Image befroeImage = null;
    bool FirstScroll = false;


    private void Start()
    {
        if (GameManager.Inst.RamanAmount <= 0)
        {
            GameManager.Inst.useRaman = false;
            ramanButton.image.color = new Color(ramanButton.image.color.r, ramanButton.image.color.g, ramanButton.image.color.b, ramanButton.image.color.a / 2);
        }

        if (GameManager.Inst.TriangleAmount <= 0)
        {
            GameManager.Inst.useTriangle = false;
            triangleButton.image.color = new Color(triangleButton.image.color.r, triangleButton.image.color.g, triangleButton.image.color.b, triangleButton.image.color.a / 2);
        }

        if (GameManager.Inst.DoshiAmount <= 0)
        {
            GameManager.Inst.useDoshi = false;
            DoshiracButton.image.color = new Color(DoshiracButton.image.color.r, DoshiracButton.image.color.g, DoshiracButton.image.color.b, DoshiracButton.image.color.a / 2);
        }
    }

    public void onRamanComp()
    {
        if (imageTrue == true)
        {
            befroeImage.gameObject.SetActive(false);
        }
        imageTrue = true;
        ramanImage.gameObject.SetActive(true);
        befroeImage = ramanImage;
        befroeImage.gameObject.SetActive(true);
        
    }

    public void OffImage()
    {
        imageTrue = false;
        befroeImage.gameObject.SetActive(false);
        befroeImage = null;
    }

    public void OnTriangleImage()
    {
        if (imageTrue == true)
        {
            befroeImage.gameObject.SetActive(false);
        }
        imageTrue = true;
        triangleImage.gameObject.SetActive(true);
        befroeImage = triangleImage;
        befroeImage.gameObject.SetActive(true);

    }

    public void OnDoshiImage()
    {
        if (imageTrue == true)
        {
            befroeImage.gameObject.SetActive(false);
        }
        imageTrue = true;
        DoshiracImage.gameObject.SetActive(true);
        befroeImage = DoshiracImage;
        befroeImage.gameObject.SetActive(true);

    }

    public void falseButton()
    {
        if (FirstScroll == true)
        {
            imageTrue = false;
            if (befroeImage != null)
            {
                befroeImage.gameObject.SetActive(false);
                befroeImage = null;
            }

        }
        if (FirstScroll == false)
        {
            FirstScroll = true;
        }
    }

    public void RamanBurf()
    {
        if (GameManager.Inst.isRaman == false)
        {
            if (GameManager.Inst.RamanAmount > 0)
            {
                GameManager.Inst.SaveData();
                GameManager.Inst.isRaman = true;
                GameManager.Inst.RamanAmount -= 1;
                ramanParticle.gameObject.SetActive(true);
                if (GameManager.Inst.RamanAmount <= 0)
                {
                    ramanButton.image.color = new Color(ramanButton.image.color.r, ramanButton.image.color.g, ramanButton.image.color.b, ramanButton.image.color.a / 2);
                }
                StartCoroutine("RamanBurfIn");
            }
        }
       
    }

    IEnumerator RamanBurfIn()
    {
        yield return new WaitForSeconds(30f);
        ramanParticle.gameObject.SetActive(false);
        RamanStopRamanBurf();
    }


    void RamanStopRamanBurf()
    {
        GameManager.Inst.isRaman = false;
    }

    public void TriangleBurf()
    {
        if(GameManager.Inst.isTriangle == false)
        {
            if (GameManager.Inst.TriangleAmount > 0)
            {
                GameManager.Inst.SaveData();
                GameManager.Inst.TriangleAmount -= 1;
                TriangleParticle.SetActive(true);
                if (GameManager.Inst.TriangleAmount <= 0)
                {
                    triangleButton.image.color = new Color(triangleButton.image.color.r, triangleButton.image.color.g, triangleButton.image.color.b, triangleButton.image.color.a / 2);
                }
                GameManager.Inst.isTriangle = true;
                StartCoroutine(TriangleBurfIn());
            }
  
        }
    }

    IEnumerator TriangleBurfIn()
    {

        yield return new WaitForSeconds(30f);
        TriangleParticle.SetActive(false);
        TriangleCoroutineStop();
    }


    public void TriangleCoroutineStop()
    {
        GameManager.Inst.isTriangle = false;
    }

    public void DoshiBurf()
    {
        if(GameManager.Inst.isDosh == false)
        {
            if (GameManager.Inst.DoshiAmount > 0)
            {
                GameManager.Inst.SaveData();
                GameManager.Inst.DoshiAmount -= 1;
                DoshParticle.SetActive(true);
                if (GameManager.Inst.DoshiAmount <= 0)
                {
                    DoshiracButton.image.color = new Color(DoshiracButton.image.color.r, DoshiracButton.image.color.g, DoshiracButton.image.color.b, DoshiracButton.image.color.a / 2);
                }
                GameManager.Inst.isDosh = true;
                StartCoroutine("DoshBurfIn");
            }
        }
    }
    IEnumerator DoshBurfIn()
    {
        yield return new WaitForSeconds(30f);
        DoshParticle.SetActive(false);
        TriangleCoroutineStop();
    }

    public void DoshCoroutineStop()
    {
        GameManager.Inst.isDosh = false;
    }
}
