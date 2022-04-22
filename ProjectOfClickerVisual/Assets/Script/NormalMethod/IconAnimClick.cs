using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class IconAnimClick : MonoBehaviour
{
    private void OnEnable()
    {
        float x = Random.Range(0.5f, 3f);
        float y = Random.Range(0.5f, 3f);
        gameObject.transform.DOMove(new Vector3(x, y, 0), 1f, false);
    }
}
