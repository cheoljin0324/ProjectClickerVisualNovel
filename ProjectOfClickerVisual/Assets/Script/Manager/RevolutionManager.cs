using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolutionManager : MonoBehaviour
{
    [SerializeField]
    private GameObject FoxObject;

    [SerializeField]
    private Sprite[] SpriteArray;

    private GameManager gameManager;

    public void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    void LevelUP()
    {
        if (gameManager) ;
    }

}