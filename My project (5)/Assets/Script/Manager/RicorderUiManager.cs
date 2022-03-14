using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RicorderUiManager : MonoBehaviour
{

    [SerializeField]
    private Transform position1 = null;
    [SerializeField]
    private Transform position2 = null;

    private bool onScroll = false;
    private bool upScroll = false;

    [SerializeField]
    private GameObject ScroolZip;

    public void PositionSwitch()
    {
        if (upScroll == false)
        {
            ScroolZip.transform.DOMove(position1.position, 0.8f);
            upScroll = true;
        }
        else if (upScroll == true)
        {
            ScroolZip.transform.DOMove(position2.position, 0.8f);
            upScroll = false;
        }

    }
}
