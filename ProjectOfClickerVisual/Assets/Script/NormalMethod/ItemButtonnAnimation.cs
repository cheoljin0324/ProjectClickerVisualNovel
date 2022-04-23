using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class ItemButtonnAnimation : MonoBehaviour
{
    [SerializeField]
    private Button itemInButton;
    [SerializeField]
    private Transform[] buttonTransform;
    [SerializeField]
    private Button[] itemButton;

    public bool isIn = false;
    public bool isOnButton = false;

    public void ItemIn()
    {
        if (isOnButton == false)
        {
            itemInButton.image.DOFade(0.5f, 1f);
            isOnButton = true;
        }
        else if(isOnButton == true)
        {
            itemInButton.image.DOFade(1f, 1f);
            isOnButton = false;
        }

        AnimItemButton();
    }

    private void AnimItemButton()
    {
        if (isIn == false)
        {
            if (GameManager.Inst.RamanAmount > 0)
            {
                itemButton[0].image.DOFade(0.2f, 1f);
            }
            else
            {
                itemButton[0].image.DOFade(0.2f, 1f);
            }

            if (GameManager.Inst.TriangleAmount > 0)
            {
                itemButton[1].image.DOFade(0.2f, 1f);
            }
            else
            {
                itemButton[1].image.DOFade(0.2f, 1f);
            }

            if (GameManager.Inst.DoshiAmount > 0)
            {
                itemButton[2].image.DOFade(0.2f, 1f);
            }
            else
            {
                itemButton[2].image.DOFade(0.2f, 1f);
            }

            itemButton[0].transform.DOMove(new Vector3(buttonTransform[0].position.x, buttonTransform[0].position.y, buttonTransform[0].position.z), 1f, false);
            itemButton[1].transform.DOMove(new Vector3(buttonTransform[1].position.x, buttonTransform[1].position.y, buttonTransform[1].position.z), 1f, false);
            itemButton[2].transform.DOMove(new Vector3(buttonTransform[2].position.x, buttonTransform[2].position.y, buttonTransform[2].position.z), 1f, false);

            itemButton[0].transform.DORotate(new Vector3(0, 0, 0), 1f, RotateMode.FastBeyond360).SetEase(Ease.Linear);
            itemButton[1].transform.DORotate(new Vector3(0, 0, 0), 1f, RotateMode.FastBeyond360).SetEase(Ease.Linear);
            itemButton[2].transform.DORotate(new Vector3(0, 0, 0), 1f, RotateMode.FastBeyond360).SetEase(Ease.Linear);

            isIn = true;
        }
        else if (isIn == true) { 

            itemButton[0].image.DOFade(0f, 1f);
            itemButton[1].image.DOFade(0f, 1f);
            itemButton[2].image.DOFade(0f, 1f);

            itemButton[0].transform.DORotate(new Vector3(0, 0, 90), 1f, RotateMode.FastBeyond360).SetEase(Ease.Linear);
            itemButton[1].transform.DORotate(new Vector3(0, 0, 90), 1f, RotateMode.FastBeyond360).SetEase(Ease.Linear);
            itemButton[2].transform.DORotate(new Vector3(0, 0, 90), 1f, RotateMode.FastBeyond360).SetEase(Ease.Linear);

            itemButton[0].transform.DOMove(new Vector3(itemInButton.transform.position.x, itemInButton.transform.position.y, itemInButton.transform.position.z), 1f, false);
            itemButton[1].transform.DOMove(new Vector3(itemInButton.transform.position.x, itemInButton.transform.position.y, itemInButton.transform.position.z), 1f, false);
            itemButton[2].transform.DOMove(new Vector3(itemInButton.transform.position.x, itemInButton.transform.position.y, itemInButton.transform.position.z), 1f, false);

            isIn = false;
        }

        
    }

        
    
}
