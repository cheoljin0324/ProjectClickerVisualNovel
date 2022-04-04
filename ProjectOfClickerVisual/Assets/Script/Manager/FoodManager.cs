using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FoodManager : MonoBehaviour
{

    [SerializeField]
    public GameObject Raman;
    [SerializeField]
    public GameObject Triangle;
    [SerializeField]
    public GameObject Doshirac;
    [SerializeField]
    public GameObject Bread;
    [SerializeField]
    public GameObject Drink;


    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Inst.RamanAmount != 0){
            Raman.SetActive(true);
        } 
        if(GameManager.Inst.TriangleAmount != 0)
        {
            Triangle.SetActive(true);
        }
        if (GameManager.Inst.DoshiAmount != 0)
        {
            Doshirac.SetActive(true);
        }
        if(GameManager.Inst.BreadAmount != 0)
        {
            Bread.SetActive(true);
        }
        if (GameManager.Inst.DrinkAmount != 0)
        {
            Drink.SetActive(true);
        }
    }
    
 
}
