using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUIManager : MonoBehaviour
{

    private bool isClick = false;

    [SerializeField]
    private Sprite[] ricorder;
    [SerializeField]
    private Image spriteRenderer;



    public void OneClick()
    {
        if (isClick == true && spriteRenderer.sprite == ricorder[0])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[0];
       
       
    }

    public void TwoClick()
    {
        if (isClick == true && spriteRenderer.sprite == ricorder[1])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[1];

    }

    public void ThreeClick()
    {
        if (isClick == true && spriteRenderer.sprite == ricorder[2])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[2];

    }

    public void FourClick()
    {
        if (isClick == true && spriteRenderer.sprite == ricorder[3])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[3];

    }

    public void FiveClick()
    {
        if (isClick == true && spriteRenderer.sprite == ricorder[4])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[4];

    }

    public void SixClick()
    {
        if (isClick == true && spriteRenderer.sprite == ricorder[5])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[5];

    }

    public void SevenClick()
    {
        if (isClick == true && spriteRenderer.sprite == ricorder[6])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[6];
    }

        public void EightClick()
        {
        if (isClick == true && spriteRenderer.sprite == ricorder[7])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[7];

    }

    public void NineClick()
    {
        if (isClick == true && spriteRenderer.sprite == ricorder[8])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[8];


    }
    public void TenClick()
    {
        if (isClick == true && spriteRenderer.sprite == ricorder[9])
        {
            gameObject.SetActive(false);
            isClick = false;
            return;
        }

        if (isClick == false)
        {
            gameObject.SetActive(true);
            isClick = true;
        }
        spriteRenderer.sprite = ricorder[9];

    }

}


