using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class RevolutionManager : MonoBehaviour
{
    [SerializeField]
    private Image[] FoxObject;

    [SerializeField]
    private SpriteRenderer FadeSprite;

    [SerializeField]
    private Sprite[] SpriteArray;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void ClickRevol()
    {
        StartCoroutine(SetRevolution());
    }

    IEnumerator SetRevolution()
    {
        if (gameManager.FoxLevel > 3)
        {
            FadeSprite.DOFade(1f, 1f);
            yield return new WaitForSeconds(1f);
            FoxObject[GameManager.Inst.FoxLevel].gameObject.SetActive(true);
            FoxObject[GameManager.Inst.FoxLevel - 1].gameObject.SetActive(true);
            for(int i = 0; i<3; i++)
            {
                FoxObject[GameManager.Inst.FoxLevel-1].transform.DOScale(new Vector3(FoxObject[GameManager.Inst.FoxLevel-1].transform.localScale.x * 1.7f, FoxObject[GameManager.Inst.FoxLevel - 1].transform.localScale.y * 1.7f, FoxObject[GameManager.Inst.FoxLevel - 1].transform.localScale.z * 1.7f), 0.4f);
                yield return new WaitForSeconds(0.4f);
            }
            FoxObject[GameManager.Inst.FoxLevel - 1].DOColor(Color.white,2f);
            FoxObject[GameManager.Inst.FoxLevel].DOColor(Color.white, 2f);
            yield return new WaitForSeconds(2f);
            FoxObject[GameManager.Inst.FoxLevel].DOFade(1, 1f);
            yield return new WaitForSeconds(1f);
            GameManager.Inst.FoxLevel++;
        }
    }

}