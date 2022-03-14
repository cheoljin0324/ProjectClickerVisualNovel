using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    [SerializeField]
    public SelectionOption[] selectionLog;

    public int selectResultNum1;
    public int selectResultNum2;

    public void SetStartselection()
    {
        for (int i = 0; i < selectionLog.Length; i++)
        {
            if (selectionLog[i].selectiobnButton.gameObject == true)
            {
                return;
            }
            else if (selectionLog[i].selectiobnButton.gameObject == false)
            {
                selectionLog[i].selectiobnButton.gameObject.SetActive(true);
            }
        }
    }

    public void ReturnResultFirst()
    {
        selectResultNum1 = 1;
    }

    public void ReturnResultSecond()
    {
        selectResultNum1 = 2;
    }

}

[System.Serializable]
public struct SelectionOption
{
    public Button selectiobnButton;
    public string selectionString;
    public int returnNum;
    
}
