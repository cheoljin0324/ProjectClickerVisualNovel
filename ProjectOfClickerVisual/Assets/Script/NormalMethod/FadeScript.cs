using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FadeScript : MonoBehaviour
{
    [SerializeField]
    GameObject FoxObject;

   public void Fade()
    {
        gameObject.GetComponent<SpriteRenderer>().DOFade(1, 1f);
    }

    
}
