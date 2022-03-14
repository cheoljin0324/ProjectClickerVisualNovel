using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LoadScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject mapCanvas;
    [SerializeField]
    private GameObject mainCanvas;
    [SerializeField]
    private GameObject RicorderShopCanvas;
    [SerializeField]
    private GameObject ShopCanvas;
    [SerializeField]
    private GameObject ClothsCanvas;

    [SerializeField]
    private Button[] buttonin;

    [SerializeField]
    private GameObject mainCanvasAni;
    [SerializeField]
    private Transform objectTransform;

    [SerializeField]
    private GameObject RythmCanvas;

    [SerializeField]
    private AudioClip[] audioclip;
    private AudioSource audio;



    public bool mainScene = true;
    public bool ShopScene = false;


    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
        GameManager.Inst.beforeAudioVolum = audio.volume;
    }

    public void SetMap()
    {
        mapCanvas.gameObject.SetActive(true);
        mainCanvasAni.transform.DOMove(new Vector3(0f, 7.7f, 0), 0.5f, false);
        Invoke("DestMain", 0.5f);

        audio.volume = GameManager.Inst.beforeAudioVolum;
    }

    private void DestMain()
    {
        mainCanvas.gameObject.SetActive(false);
    }


    public void SetRiShop()
    {
        buttonin[0].transform.DOScale(new Vector3(0.85f, 0.85f, 0), 0.1f);
        Invoke("SetRiShopInspect", 0.5f);

        Invoke("LoadRishop", 0.15f);
        
        mainScene = false;
        ShopScene = true;

        audio.clip = audioclip[1];
        audio.Play();
    }

    private void LoadRishop()
    {
        RicorderShopCanvas.gameObject.SetActive(true);
        mapCanvas.gameObject.SetActive(false);

    }

    private void LoadItemShop()
    {
        ShopCanvas.gameObject.SetActive(true);
        mapCanvas.gameObject.SetActive(false);
    }

    private void SetRiShopInspect()
    {
        buttonin[0].transform.DOScale(new Vector3(1f, 1f, 0), 0.5f);
    }

    private void SetRiShopInspect1()
    {
        buttonin[1].transform.DOScale(new Vector3(1f, 1f, 0), 0.5f);
    }

    public void SetItemShop()
    {
        buttonin[1].transform.DOScale(new Vector3(0.85f, 0.85f, 0), 0.1f);
        Invoke("SetRiShopInspect1", 0.5f);

        Invoke("LoadItemShop", 0.15f);

        mainScene = false;
        ShopScene = true;

        audio.clip = audioclip[1];
        audio.Play();
    }

    private void SetRiShopInspect2()
    {
        buttonin[2].transform.DOScale(new Vector3(1f, 1f, 0), 0.5f);
    }

    private void LoadClothsShop()
    {
        ShopCanvas.gameObject.SetActive(true);
        mapCanvas.gameObject.SetActive(false);
    }



    public void SetClothsShop()
    {
        buttonin[2].transform.DOScale(new Vector3(0.85f, 0.85f, 0), 0.1f);
        Invoke("SetRiShopInspect2", 0.5f);

        Invoke("LoadClothsShop", 0.15f);

        mainScene = false;
        ShopScene = true;

        audio.clip = audioclip[1];
        audio.Play();
    }

    public void ExitMap()
    {
        mainCanvas.gameObject.SetActive(true);
        mapCanvas.gameObject.SetActive(false);
        mainCanvasAni.transform.position = objectTransform.position;
    }

    public void ExitRiShop()
    {
        mapCanvas.gameObject.SetActive(true);
        RicorderShopCanvas.gameObject.SetActive(false);

        mainScene = true;
        ShopScene = false;

        audio.clip = audioclip[0];
        audio.Play();
    }

    public void ExitItemShop()
    {
        mapCanvas.gameObject.SetActive(true);
        ShopCanvas.gameObject.SetActive(false);

        mainScene = true;
        ShopScene = false;

        audio.clip = audioclip[0];
        audio.Play();
    }

    public void ExitClothsShop()
    {
        mapCanvas.gameObject.SetActive(true);
        ClothsCanvas.gameObject.SetActive(false);

        mainScene = true;
        ShopScene = false;

        audio.clip = audioclip[0];
        audio.Play();
    }

    public void SetRythm()
    {
        audio.volume = GameManager.Inst.beforeAudioVolum;
        RythmCanvas.SetActive(true);
        mainCanvas.SetActive(false);
    }

    public void OutRythm()
    {
        mainCanvas.SetActive(true);
        RythmCanvas.SetActive(false);
        audio.volume = GameManager.Inst.beforeAudioVolum;
    }
  
}
