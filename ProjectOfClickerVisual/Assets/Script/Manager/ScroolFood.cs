using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScroolFood : MonoBehaviour
{
    [SerializeField]
    private Transform foodScroolingPosition;
    [SerializeField]
    private Transform beforeFoodTransform;

    private long ramanCharMoney = 1;
    private long triangleMoney = 1;
    private long doshraracMoney = 1;
    private long breadMoney = 1;
    private long drinkMoney = 1;

    private bool isScrolling = false;


    public void Scroll()
    {
        if (isScrolling == false)
        {
            gameObject.transform.DOMove(foodScroolingPosition.position, 1f, false);
            isScrolling = true;
        }
        else if (isScrolling == true)
        {
            gameObject.transform.DOMove(beforeFoodTransform.position, 1f, false);
            isScrolling = false;
        }

    }

    public void RamanChar()
    {
        GameManager.Inst.RamanAmount += 1;
        GameManager.Inst.coinB -= ramanCharMoney;
        GameManager.Inst.coinBText.text = GameManager.Inst.coinB.ToString();
        GameManager.Inst.SaveData();
    }

    public void Triangle()
    {
        GameManager.Inst.TriangleAmount += 1;
        GameManager.Inst.coinB -= triangleMoney;
        GameManager.Inst.coinBText.text = GameManager.Inst.coinB.ToString();
        GameManager.Inst.SaveData();
    }

    public void Doshirac()
    {
        GameManager.Inst.DoshiAmount += 1;
        GameManager.Inst.coinB -= doshraracMoney;
        GameManager.Inst.coinBText.text = GameManager.Inst.coinB.ToString();
        GameManager.Inst.SaveData();
    }

    public void Bread()
    {
        GameManager.Inst.BreadAmount += 1;
        GameManager.Inst.coinB -= breadMoney;
        GameManager.Inst.coinBText.text = GameManager.Inst.coinB.ToString();
        GameManager.Inst.SaveData();

    }

    public void Drink()
    {
        GameManager.Inst.DrinkAmount += 1;
        GameManager.Inst.coinB -= drinkMoney;
        GameManager.Inst.coinBText.text = GameManager.Inst.coinB.ToString();
        GameManager.Inst.SaveData();
    }

}
