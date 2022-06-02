using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ObjectFirst : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnFirst()
    {
        if(gameManager.NowLoadScene == true)
        {
            StartCoroutine(ShutUpLoop());
        }
        else
        {
            SceneManager.LoadScene("Main");
        }
    }

    IEnumerator ShutUpLoop()
    {
        for(int i = 0; i<2; i++)
        {
            gameObject.GetComponent<SpriteRenderer>().DOFade(0f, 0.4f);
            yield return new WaitForSeconds(0.4f);
            gameObject.GetComponent<SpriteRenderer>().DOFade(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }
    }
}
