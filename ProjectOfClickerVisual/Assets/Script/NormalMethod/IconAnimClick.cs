using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine;

public class IconAnimClick : MonoBehaviour
{
    [SerializeField]
    private Image startTransform;
    [SerializeField]
    private GameObject endTransform;

    private void Awake()
    {
        gameObject.transform.position = new Vector3(startTransform.transform.position.x, startTransform.transform.position.y, -10);
    }

    private void OnEnable()
    {
        gameObject.transform.position = new Vector3(startTransform.transform.position.x, startTransform.transform.position.y, -10);

        float x = Random.Range(-3f, 3f);
        float y = Random.Range(-3f, 3f);
        gameObject.transform.DOMove(new Vector3(x, y, startTransform.transform.position.z+100), 1f, false);

        StartCoroutine(SetCoinCoroutine());
    }

    IEnumerator SetCoinCoroutine()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.transform.DOMove(new Vector2(0, -6),0.5f,false);
       
    }
}
