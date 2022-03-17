using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine;

public class HighLowPositionManager : MonoBehaviour
{
    [SerializeField]
    private GameObject fiveLinPaperOb;

    [SerializeField]
    private Button leftButton;
    [SerializeField]
    private Button rightButton;

    [SerializeField]
    private Transform[] fiveLinPaperPos;

    public int paperPosition = 0;

    // Update is called once per frame

    private void Start()
    {
        fiveLinPaperOb.transform.position = fiveLinPaperPos[0].position;
        leftButton.gameObject.SetActive(false);
    }

    public void LeftArrow()
    {
        paperPosition -= 1;
        MoveTransform();

        if (paperPosition == 0)
        {
            leftButton.gameObject.SetActive(false);
        }
        else
        {
            leftButton.gameObject.SetActive(true);
        }
    }

    public void RightArrow()
    {
        paperPosition += 1;
        MoveTransform();

        if (paperPosition == 5)
        {
            rightButton.gameObject.SetActive(false);
        }
        else
        {
            rightButton.gameObject.SetActive(true);
        }
    }

    private void MoveTransform()
    {
        fiveLinPaperOb.transform.DOMove(new Vector3(fiveLinPaperPos[paperPosition].position.x, fiveLinPaperPos[paperPosition].position.y, fiveLinPaperPos[paperPosition].position.z), 1f, false);
        rightButton.gameObject.SetActive(true);
        leftButton.gameObject.SetActive(true);
    }
}
