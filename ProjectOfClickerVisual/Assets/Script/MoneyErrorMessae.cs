using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MoneyErrorMessae : MonoBehaviour
{
    private Image erImage;




    // Start is called before the first frame update
    void Start()
    {
        erImage = GetComponent<Image>();
        MoneyError();
    }

    void MoneyError()
    {
        
       
        erImage.transform.DOMove(new Vector3(erImage.transform.position.x, 1f, 0f), 0.8f, false);
        erImage.DOFade(0f, 0.7f);
        Invoke("erDes", 1f);
    }

    void erDes()
    {
        Destroy(gameObject);
    }
}
