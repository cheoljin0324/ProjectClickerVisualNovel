using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Click : MonoBehaviour
{
    public float destroyTime = 1f;
    SpriteRenderer sprite;

    private void Start()
    {
        transform.position = new Vector3(GameManager.Inst.transpos.x, GameManager.Inst.transpos.y, 0);
        gameObject.transform.DOScale(new Vector3(0.3f, 0.3f, 0), 0.5f);

        sprite = GetComponent<SpriteRenderer>();
        sprite.material.DOFade(0, 0.8f);
        

        Invoke("DestroyObject", destroyTime);
    }
    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
