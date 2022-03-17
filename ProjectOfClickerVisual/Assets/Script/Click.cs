using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Click : MonoBehaviour
{
    public float destroyTime = 1f;
    SpriteRenderer sprite;
    private bool isfirst = false;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        if(isfirst == true)
        {
            sprite.color = new Color(1f, 1f, 1f, 1f);
        }
        sprite.DOFade(0, 1f);
        gameObject.transform.localScale = new Vector3(0f, 0f, 0f);
        transform.position = new Vector3(GameManager.Inst.transpos.x, GameManager.Inst.transpos.y, 0);
        gameObject.transform.DOScale(new Vector3(0.3f, 0.3f, 0), 0.8f);

        if (isfirst == false)
        {
            isfirst = true;
        }
    }

}
