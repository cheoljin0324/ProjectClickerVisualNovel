using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScrollFood : MonoBehaviour
{
    [SerializeField]
    private GameObject PositionObject;
    [SerializeField]
    private GameObject beforPosition;

    private bool isOnMove = false;

    private void Start()
    {

    }

    public void ScrollMove()
    {
        

        if (isOnMove == false)
        {
            gameObject.transform.DOMove(PositionObject.transform.position, 1f, false);
            isOnMove = true;
        }

        else if (isOnMove == true)
        {
            gameObject.transform.DOMove(beforPosition.transform.position, 1f, false);
            isOnMove = false;
        }

    }

}
