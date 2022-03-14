using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private Button setbutton;

    [SerializeField]
    private Sprite maincharSprite;

    [SerializeField]
    private Sprite[] sprite;

    [SerializeField]
    private Button buttonTest;
    [SerializeField]
    private Button mapButton;


    [SerializeField]
    private Image imageoptionGameObject;

    [SerializeField]
    private Transform[] buttonTransform;

    [SerializeField]
    private Text textFull;



    public Button clothsButton;

    public Button recorderButton;

    private bool isTrueOption = false;

    public Button revolButton;

    private bool isOnSet = false;
    private bool isOnButton = false;


    private void Update()
    {
        textFull.text = GameManager.Inst.plCoin.ToString();
    }

    public void SetButton()
    {
        if (isOnSet == false)
        {
            StartButoon();
        }
        else if(isOnSet==true){
            ReturnButoon();
        }
        
    }

    private void StartButoon()
    {
       
        setbutton.image.DOFade(0.5f, 0.5f);


        recorderButton.gameObject.SetActive(true);
        recorderButton.image.DOFade(1f, 0.5f);
        recorderButton.transform.DOMove(new Vector3(setbutton.transform.position.x, buttonTransform[2].position.y, 0), 0.5f, false);

        clothsButton.gameObject.SetActive(true);
        clothsButton.image.DOFade(1, 0.5f);
        clothsButton.transform.DOMove(new Vector3(setbutton.transform.position.x, buttonTransform[1].position.y, 0), 0.5f, false);

        revolButton.gameObject.SetActive(true);
        revolButton.image.DOFade(1, 0.5f);
        revolButton.transform.DOMove(new Vector3(setbutton.transform.position.x, buttonTransform[0].position.y, 0), 0.5f, false);

        

        isOnSet = true;
    }

    private void ReturnButoon()
    {
        setbutton.image.DOFade(1f, 0.5f);

        recorderButton.gameObject.SetActive(true);
        recorderButton.image.DOFade(0, 0.5f);
        recorderButton.transform.DOMove(new Vector3(setbutton.transform.position.x, setbutton.transform.position.y, 0), 0.5f, false);

        clothsButton.gameObject.SetActive(true);
        clothsButton.image.DOFade(0, 0.5f);
        clothsButton.transform.DOMove(new Vector3(setbutton.transform.position.x, setbutton.transform.position.y, 0), 0.5f, false);

        revolButton.gameObject.SetActive(true);
        revolButton.image.DOFade(0, 0.5f);
        revolButton.transform.DOMove(new Vector3(setbutton.transform.position.x, setbutton.transform.position.y, 0), 0.5f, false);

        isOnSet = false;
        isOnButton = false;
    }

    public void NoTest()
    {
        buttonTest.gameObject.SetActive(true);
    }

    public void NoTestFalse()
    {
        buttonTest.gameObject.SetActive(false);
    }

    public void MapTest()
    {
        mapButton.gameObject.SetActive(true);
    }
    public void NoMapTest()
    {
        mapButton.gameObject.SetActive(false);
    }



    public void OnOption()
    {
        if (isTrueOption == false)
        {
            imageoptionGameObject.gameObject.SetActive(true);
            isTrueOption = true;
        }
        else if (isTrueOption == true)
        {
            imageoptionGameObject.gameObject.SetActive(false);
            isTrueOption = false;
        }
        
    }

    public void OffOption()
    {
        imageoptionGameObject.gameObject.SetActive(false);
        isTrueOption = false;
    }
}
