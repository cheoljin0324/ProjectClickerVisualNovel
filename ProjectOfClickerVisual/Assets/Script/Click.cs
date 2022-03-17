using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Click : MonoBehaviour
{
    public float destroyTime = 1f;
    SpriteRenderer sprite;
    SpriteRenderer onSprite;
    SpriteRenderer OffSprite;

    private void Start()
    {
        transform.position = new Vector3(GameManager.Inst.transpos.x, GameManager.Inst.transpos.y, 0);
        gameObject.transform.DOScale(new Vector3(0.3f, 0.3f, 0), 0.5f);

        sprite = GetComponent<SpriteRenderer>();
        onSprite = sprite;
        OffSprite = sprite;

        OffSprite.material.DOFade(0, 0.8f);
        sprite.material.DOFade(0, 0.8f);

        Destroy(gameObject, 0.8f);
        
    }
    private IEnumerator FadOf(SpriteRenderer sprite)
    {
        yield return new WaitForSeconds(0.8f);
        if (sprite.material == OffSprite.material)
        {
            sprite.material = onSprite.material;
        }
    }

}
