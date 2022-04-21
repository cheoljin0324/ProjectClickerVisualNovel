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
    [SerializeField]
    private FoodMethodA foodMethodA;

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
        GameManager.Inst.useRaman = true;
        if (GameManager.Inst.RamanAmount == 1)
        {
            foodMethodA.ramanButton.image.color = new Color(foodMethodA.ramanButton.image.color.r, foodMethodA.ramanButton.image.color.g, foodMethodA.ramanButton.image.color.b, foodMethodA.ramanButton.image.color.a * 2);
        }
       
    }

    public void Triangle()
    {
        GameManager.Inst.TriangleAmount += 1;
        GameManager.Inst.coinB -= triangleMoney;
        GameManager.Inst.coinBText.text = GameManager.Inst.coinB.ToString();
        GameManager.Inst.SaveData();
        GameManager.Inst.useTriangle = true;
        if (GameManager.Inst.TriangleAmount == 1)
        {
            foodMethodA.triangleButton.image.color = new Color(foodMethodA.triangleButton.image.color.r, foodMethodA.triangleButton.image.color.g, foodMethodA.triangleButton.image.color.b, foodMethodA.triangleButton.image.color.a * 2);
        }
    }

    public void Doshirac()
    {
        GameManager.Inst.DoshiAmount += 1;
        GameManager.Inst.coinB -= doshraracMoney;
        GameManager.Inst.coinBText.text = GameManager.Inst.coinB.ToString();
        GameManager.Inst.SaveData();
        GameManager.Inst.useDoshi = true;
        if (GameManager.Inst.DoshiAmount == 1)
        {
            foodMethodA.DoshiracButton.image.color = new Color(foodMethodA.DoshiracButton.image.color.r, foodMethodA.DoshiracButton.image.color.g, foodMethodA.DoshiracButton.image.color.b, foodMethodA.DoshiracButton.image.color.a * 2);
        }
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
