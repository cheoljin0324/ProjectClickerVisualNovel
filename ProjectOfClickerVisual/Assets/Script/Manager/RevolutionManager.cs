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

    public Revolutiondata revolData;



    public void LevelUP()
    {
        if (revolData.FoxLevel == 1)
        {
            revolData.FoxLevel += 1;
            StartCoroutine(RevolustionTrans());
            SceneManager.LoadScene("RevolutionScene");
            DontDestroyOnLoad(revolData);

            SpriteSet(1);
        }
        else if(revolData.FoxLevel == 2)
        {
            revolData.FoxLevel += 1;
            StartCoroutine(RevolustionTrans());
            SceneManager.LoadScene("RevolutionScene");
            DontDestroyOnLoad(revolData);

            SpriteSet(2);
        }
    }

    IEnumerator RevolustionTrans()
    {
        FadeSprite.DOFade(1, 1f);
        yield return new WaitForSeconds(1f);
    }
    void SpriteSet(int seti)
    {
        FoxObject.sprite = SpriteArray[seti];
    }

}