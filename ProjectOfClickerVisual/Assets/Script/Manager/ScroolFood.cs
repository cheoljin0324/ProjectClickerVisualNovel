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
    }

    public void Triangle()
    {
        GameManager.Inst.TriangleAmount += 1;
    }

    public void Doshirac()
    {
        GameManager.Inst.DoshiAmount += 1;
    }

    public void Bread()
    {
        GameManager.Inst.BreadAmount += 1;
    }

    public void Drink()
    {
        GameManager.Inst.DrinkAmount += 1;
    }

}
