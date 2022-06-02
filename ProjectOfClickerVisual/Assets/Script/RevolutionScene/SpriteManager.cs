using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    [SerializeField]
    private Sprite[] spriteSet;
    Revolutiondata revolData;

    private void Awake()
    {
        revolData = GameObject.Find("RevolData").GetComponent<Revolutiondata>();
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteSet[revolData.FoxLevel-1];
    }
}
