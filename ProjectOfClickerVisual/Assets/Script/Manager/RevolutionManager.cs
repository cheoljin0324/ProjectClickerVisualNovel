using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class RevolutionManager : MonoBehaviour
{
    [SerializeField]
    private Image FoxObject;

    [SerializeField]
    private SpriteRenderer FadeSprite;

    [SerializeField]
    private Sprite[] SpriteArray;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }

    void SetRevolution()
    {
        if (gameManager.FoxLevel > 3)
        {
            FadeSprite.DOFade(1f, 1f);
        }
    }

}