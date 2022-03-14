using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;

public class RiCorderShopManager : MonoBehaviour
{
    [SerializeField]
    private Image[] RicorderGuard;
    [SerializeField]
    private Text[] textMoney;
    [SerializeField]
    private GameObject errorPrefab;
    [SerializeField]
    private Transform gameObjectPosition;


    private BigInteger level1Money = 1;
    private BigInteger level2Money = 30;
    private BigInteger level3Money = 1000;
    private BigInteger level4Money = 1;
    private BigInteger level5Money = 1;
    private BigInteger level6Money = 1;
    private BigInteger level7Money = 1;
    private BigInteger level8Money = 1;
    private BigInteger level9Money = 1;
    private BigInteger level10Money = 1;

    private string[] unit = { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "W", "X", "Y", "Z" };

    private void Awake()
    {
        LoadMoney();
    }

    private void Start()
    {
        TextUpdate();
        LoadMoney();
    }

    private void SaveMoney()
    {
        PlayerPrefs.SetString("level1Money", level1Money.ToString());
        PlayerPrefs.SetString("level2Money", level2Money.ToString());
        PlayerPrefs.SetString("level3Money", level3Money.ToString());
        PlayerPrefs.SetString("level4Money", level4Money.ToString());
        PlayerPrefs.SetString("level5Money", level5Money.ToString());
        PlayerPrefs.SetString("level6Money", level6Money.ToString());
        PlayerPrefs.SetString("level7Money", level7Money.ToString());
        PlayerPrefs.SetString("level8Money", level8Money.ToString());
        PlayerPrefs.SetString("level9Money", level9Money.ToString());
        PlayerPrefs.SetString("level10Money", level10Money.ToString());
    }

    private void LoadMoney()
    {
        string a;
        a = PlayerPrefs.GetString("level1Money", level1Money.ToString());
        level1Money = BigInteger.Parse(a);

        a = PlayerPrefs.GetString("level2Money", level2Money.ToString());
        level2Money = BigInteger.Parse(a);

        a = PlayerPrefs.GetString("level3Money", level3Money.ToString());
        level3Money = BigInteger.Parse(a);

        a = PlayerPrefs.GetString("level4Money", level4Money.ToString());
        level4Money = BigInteger.Parse(a);

        a = PlayerPrefs.GetString("level5Money", level5Money.ToString());
        level5Money = BigInteger.Parse(a);

        a = PlayerPrefs.GetString("level6Money", level6Money.ToString());
        level6Money = BigInteger.Parse(a);

        a = PlayerPrefs.GetString("level7Money", level7Money.ToString());
        level7Money = BigInteger.Parse(a);

        a = PlayerPrefs.GetString("level8Money", level8Money.ToString());
        level8Money = BigInteger.Parse(a);

        a = PlayerPrefs.GetString("level9Money", level9Money.ToString());
        level9Money = BigInteger.Parse(a);

        a = PlayerPrefs.GetString("level10Money", level10Money.ToString());
        level10Money = BigInteger.Parse(a);

    }

    public void RicorderUiUpdate()
    {
        if (GameManager.Inst.RpcLevel1 > 50) RicorderGuard[0].gameObject.SetActive(false);
        if (GameManager.Inst.RpcLevel2 > 50) RicorderGuard[1].gameObject.SetActive(false);
        if (GameManager.Inst.RpcLevel3 > 50) RicorderGuard[2].gameObject.SetActive(false);
        if (GameManager.Inst.RpcLevel4 > 50) RicorderGuard[3].gameObject.SetActive(false);
        if (GameManager.Inst.RpcLevel5 > 50) RicorderGuard[4].gameObject.SetActive(false);
        if (GameManager.Inst.RpcLevel6 > 50) RicorderGuard[5].gameObject.SetActive(false);
        if (GameManager.Inst.RpcLevel7 > 50) RicorderGuard[6].gameObject.SetActive(false);
        if (GameManager.Inst.RpcLevel8 > 50) RicorderGuard[7].gameObject.SetActive(false);
        if (GameManager.Inst.RpcLevel9 > 50) RicorderGuard[8].gameObject.SetActive(false);
    }

    public void BuyRicorder1Level()
    {
        if (GameManager.Inst.plCoin < level1Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity, GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        Debug.Log(level1Money);

        GameManager.Inst.plCoin -= level1Money;
        level1Money = level1Money+GameManager.Inst.RpcLevel1 * (GameManager.Inst.RpcLevel1*2)*2;
        GameManager.Inst.RpcLevel1 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();

    }

   

    public void BuyRicorder2Level()
    {
        if (GameManager.Inst.plCoin < level2Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity, GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        GameManager.Inst.plCoin -= level2Money;
        level2Money = (level2Money + GameManager.Inst.RpcLevel2 * (GameManager.Inst.RpcLevel2 * 2)* 6);
        GameManager.Inst.RpcLevel2 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();
    }

    public void BuyRicorder3Level()
    {
        if (GameManager.Inst.plCoin < level3Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity, GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        GameManager.Inst.plCoin -= level3Money;
        level3Money = (level3Money + GameManager.Inst.RpcLevel3 * (GameManager.Inst.RpcLevel3 * 2) * 14);
        GameManager.Inst.RpcLevel3 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();
    }

    public void BuyRicorder4Level()
    {
        if (GameManager.Inst.plCoin < level4Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity, GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        GameManager.Inst.plCoin -= level4Money;
        level4Money = (level4Money = level4Money + GameManager.Inst.RpcLevel4 * (GameManager.Inst.RpcLevel4 * 2)* 30);
        GameManager.Inst.RpcLevel4 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();
    }

    public void BuyRicorder5Level()
    {
        if (GameManager.Inst.plCoin < level5Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity, GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        GameManager.Inst.plCoin -= level5Money;
        level5Money = (level5Money = level5Money + GameManager.Inst.RpcLevel5 * (GameManager.Inst.RpcLevel5 * 2) * 16);
        GameManager.Inst.RpcLevel5 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();
    }

    public void BuyRicorder6Level()
    {
        if (GameManager.Inst.plCoin < level6Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity, GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        GameManager.Inst.plCoin -= level6Money;
        level6Money = (level6Money = level6Money + GameManager.Inst.RpcLevel6 * (GameManager.Inst.RpcLevel6 * 2) * 18);
        Debug.Log(level6Money);
        GameManager.Inst.RpcLevel6 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();
    }

    public void BuyRicorder7Level()
    {
        if (GameManager.Inst.plCoin < level7Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity, GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        GameManager.Inst.plCoin -= level7Money;
        level7Money = (level7Money + GameManager.Inst.RpcLevel7 * (GameManager.Inst.RpcLevel7 * 2)) * 20;
        GameManager.Inst.RpcLevel7 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();
    }

    public void BuyRicorder8Level()
    {
        if (GameManager.Inst.plCoin < level8Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity, GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        GameManager.Inst.plCoin -= level8Money;
        level8Money = (level8Money + GameManager.Inst.RpcLevel8 * (GameManager.Inst.RpcLevel8 * 2))  * 22;
        GameManager.Inst.RpcLevel8 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();
    }

    public void BuyRicorder9Level()
    {
        if (GameManager.Inst.plCoin < level9Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity, GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        Debug.Log(level9Money);

        GameManager.Inst.plCoin -= level9Money;
        level9Money = (level9Money + GameManager.Inst.RpcLevel9 * (GameManager.Inst.RpcLevel9 * 2))*24;
        GameManager.Inst.RpcLevel9 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();

    }

    public void BuyRicorder10Level()
    {
        if (GameManager.Inst.plCoin < level10Money)
        {
            Instantiate(errorPrefab, gameObjectPosition.position, UnityEngine.Quaternion.identity,GameObject.Find("RicorderShopCanvas").transform);
            return;
        }

        Debug.Log(level10Money);

        GameManager.Inst.plCoin -= level10Money;
        level10Money = (level10Money + GameManager.Inst.RpcLevel10 * (GameManager.Inst.RpcLevel10 * 2)*26);
        GameManager.Inst.RpcLevel10 += 1;

        RicorderUiUpdate();
        GameManager.Inst.SaveData();
        TextUpdate();
        SaveMoney();

    }

    private void TextUpdate()
    {

        UpdateText1();
        UpdateText2();
        UpdateText3();
        UpdateText4();
        UpdateText5();
        UpdateText6();
        UpdateText7();
        UpdateText8();
        UpdateText9();
        UpdateText10();
    }

    void UpdateText1()
    {
        BigInteger renderNum = level1Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[0].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[0].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
    void UpdateText2()
    {
        BigInteger renderNum = level2Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[1].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[1].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
    void UpdateText3()
    {
        BigInteger renderNum = level3Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[2].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[2].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
    void UpdateText4()
    {
        BigInteger renderNum = level4Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[3].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[3].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
    void UpdateText5()
    {
        BigInteger renderNum = level5Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[4].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[4].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
    void UpdateText6()
    {
        BigInteger renderNum = level6Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[5].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[5].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
    void UpdateText7()
    {
        BigInteger renderNum = level7Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[6].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[6].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
    void UpdateText8()
    {
        BigInteger renderNum = level8Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[7].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[7].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
    void UpdateText9()
    {
        BigInteger renderNum = level9Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[8].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[8].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
    void UpdateText10()
    {
        BigInteger renderNum = level10Money;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            textMoney[9].text = renderNum.ToString();
            return;
        }

        for (int i = 0; i < unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                textMoney[9].text = renderNum.ToString() + "." + defalt + unit[stack];
                break;
            }

        }
    }
}
