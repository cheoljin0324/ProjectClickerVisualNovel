using System.IO;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;
using TMPro;



public class GameManager : MonoSingleton<GameManager>
{

    public BigInteger plCoin = 0;
    [SerializeField]
    public long Rpc = 0;
    [SerializeField]
    private Text coinTxt;

    [SerializeField]
    private GameObject Raman;
    [SerializeField]
    private GameObject Triangle;
    [SerializeField]
    private GameObject Doshirac;
    [SerializeField]
    private GameObject Bread;
    [SerializeField]
    private GameObject Drink;

    [SerializeField]
    private GameObject TestError;

    [SerializeField]
    private RiCorderShopManager ricorderShop;



    public bool isTuto = false;

    public bool isMain = true;
    
    public int RpcLevel1 = 1;
    public int RpcLevel2 = 0;
    public int RpcLevel3 = 0;
    public int RpcLevel4 = 0;
    public int RpcLevel5 = 0;
    public int RpcLevel6 = 0;
    public int RpcLevel7 = 0;
    public int RpcLevel8 = 0;
    public int RpcLevel9 = 0;
    public int RpcLevel10 = 0;

    private int audioS = 0;

    private float TimeLeft = 1.0f;
    private float TimeRIg = 0.1f;
    private float nextTime = 0.0f;
    private float andTime = 0.5f;

    public int pianoLevel = 0;
    public int drumLevel = 0;
    public int micLevel = 0;
    public int tamLevel = 0;
    public int flutLevel = 0;

    public int RamanAmount = 0;
    public int TriangleAmount = 0;
    public int DoshiAmount = 0;
    public int DrinkAmount = 0;
    public int BreadAmount = 0;

    public int pianoMoney = 1;
    public int micMoney = 1;
    public int drumMoney = 1;
    public int tamMoney = 1;
    public int flutMoney = 1;

    public int pianoSpriteLevel = 0;
    public int micSpriteLevel = 0;
    public int drumSpriteLevel = 0;
    public int tamSpriteLevel = 0;
    public int flutSpriteLevel = 0;

    public bool isRaman = false;
    public bool isDosh = false;
    public bool isTriangle = false;
    public bool isDrink = false;
    public bool isBread = false;

    public long coinB = 0;

    [SerializeField]
    public Text coinBText;

    [SerializeField]
    public int Rps = 0;

    [SerializeField]
    private Image playerImage;

    [SerializeField]
    private PoolManager poolManager;

    [SerializeField]
    public GameObject effectTextMesh;

    [SerializeField]
    public GameObject effectClick;

    [SerializeField]
    public AudioClip[] audioRecorder;
    [SerializeField]
    public AudioClip[] recorderAudioData;

    [SerializeField]
    public AudioSource loadaudio;

    public AudioSource audioSource;

    public float beforeAudioVolum=0;

    public bool isclick = false;

    public bool AudioControlSh = false;

    public bool clickAct = false;
    private float timeInt = 0f;

    public int recorderStack = 0;

    public UnityEngine.Vector3 transpos;

    public int RpsA = 1;

    private string[] unit = { " ","A", "B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","W","X","Y","Z","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AW","AX","AY","AZ" };

    public void ExitGame()
    {
        Application.Quit();
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        LoadData();
        ricorderShop.RicorderUiUpdate();
        UpdateText();

        coinBText.text = coinB.ToString();

        Debug.Log(loadaudio.volume);

        for(int i = 0; i<16; i++)
        {
            audioRecorder[i] = recorderAudioData[0];
        }
    }
    public void SaveData()
    {
        PlayerPrefs.SetString("plCoin", plCoin.ToString());
        PlayerPrefs.SetInt("RpcLevel1", RpcLevel1);
        PlayerPrefs.SetInt("RpcLevel2", RpcLevel2);
        PlayerPrefs.SetInt("RpcLevel3", RpcLevel3);
        PlayerPrefs.SetInt("RpcLevel4", RpcLevel4);
        PlayerPrefs.SetInt("RpcLevel6", RpcLevel6);
        PlayerPrefs.SetInt("RpcLevel5", RpcLevel5);
        PlayerPrefs.SetInt("RpcLevel7", RpcLevel7);
        PlayerPrefs.SetInt("RpcLevel8", RpcLevel8);
        PlayerPrefs.SetInt("RpcLevel9", RpcLevel9);
        PlayerPrefs.SetInt("RpcLevel10", RpcLevel10);
        PlayerPrefs.SetInt("MicLevel", micLevel);
        PlayerPrefs.SetInt("DrumLevel", drumLevel);
        PlayerPrefs.SetInt("PianoLevel", pianoLevel);
        PlayerPrefs.SetInt("FlutLevel", flutLevel);
        PlayerPrefs.SetInt("TamburinLevel", tamLevel);
        PlayerPrefs.SetInt("PianoSpriteLevel", pianoSpriteLevel);
        PlayerPrefs.SetInt("DrumSpriteLevel", drumSpriteLevel);
        PlayerPrefs.SetInt("MicSpriteLevel", micSpriteLevel);
        PlayerPrefs.SetInt("FlutSpriteLevel", flutSpriteLevel);
        PlayerPrefs.SetInt("TamburinSpriteLevel", tamSpriteLevel);
        PlayerPrefs.SetInt("PianoMoney", pianoMoney);
        PlayerPrefs.SetInt("DrumMoney", drumMoney);
        PlayerPrefs.SetInt("MicMoney", micMoney);
        PlayerPrefs.SetInt("FlutMoney", flutMoney);
        PlayerPrefs.SetInt("TamBurinMoney", tamMoney);
        PlayerPrefs.SetString("CoinB", coinB.ToString());
        PlayerPrefs.SetInt("Raman", RamanAmount);
        PlayerPrefs.SetInt("Dosh", DoshiAmount);
        PlayerPrefs.SetInt("Triangle", TriangleAmount);

        Debug.Log("세이브");
    }

    public void LoadData()
    {
        string a;
        string b;

        a = PlayerPrefs.GetString("plCoin",plCoin.ToString());
        plCoin = BigInteger.Parse(a);
        RpcLevel1 = PlayerPrefs.GetInt("RpcLevel1", RpcLevel1);
        RpcLevel2 = PlayerPrefs.GetInt("RpcLevel2", RpcLevel2);
        RpcLevel3 = PlayerPrefs.GetInt("RpcLevel3", RpcLevel3);
        RpcLevel4 = PlayerPrefs.GetInt("RpcLevel4", RpcLevel4);
        RpcLevel5 = PlayerPrefs.GetInt("RpcLevel5", RpcLevel5);
        RpcLevel6 = PlayerPrefs.GetInt("RpcLevel6", RpcLevel6);
        RpcLevel7 = PlayerPrefs.GetInt("RpcLevel7", RpcLevel7);
        RpcLevel8 = PlayerPrefs.GetInt("RpcLevel8", RpcLevel8);
        RpcLevel9 = PlayerPrefs.GetInt("RpcLevel9", RpcLevel9);
        RpcLevel10 = PlayerPrefs.GetInt("RpcLevel10", RpcLevel10);
        micLevel = PlayerPrefs.GetInt("MicLevel", micLevel);
        drumLevel = PlayerPrefs.GetInt("DrumLevel", drumLevel);
        pianoLevel = PlayerPrefs.GetInt("PianoLevel", pianoLevel);
        flutLevel = PlayerPrefs.GetInt("FlutLevel", flutLevel);
        tamLevel = PlayerPrefs.GetInt("TamburinLevel", tamLevel);
        pianoSpriteLevel = PlayerPrefs.GetInt("PianoSpriteLevel", pianoSpriteLevel);
        drumSpriteLevel = PlayerPrefs.GetInt("DrumSpriteLevel", drumSpriteLevel);
        micSpriteLevel = PlayerPrefs.GetInt("MicSpriteLevel", micSpriteLevel);
        flutSpriteLevel = PlayerPrefs.GetInt("FlutSpriteLevel", flutSpriteLevel);
        tamSpriteLevel = PlayerPrefs.GetInt("TamburinSpriteLevel", tamSpriteLevel);
        pianoMoney = PlayerPrefs.GetInt("PianoMoney", pianoMoney);
        drumMoney = PlayerPrefs.GetInt("DrumMoney", drumMoney);
        micMoney = PlayerPrefs.GetInt("MicMoney", micMoney);
        flutMoney = PlayerPrefs.GetInt("FlutMoney", flutMoney);
        tamMoney = PlayerPrefs.GetInt("TamBurinMoney", tamMoney);
        RamanAmount = PlayerPrefs.GetInt("Raman", RamanAmount);
        DoshiAmount = PlayerPrefs.GetInt("Dosh", DoshiAmount);
        TriangleAmount = PlayerPrefs.GetInt("Triangle", TriangleAmount);
        b = PlayerPrefs.GetString("CoinB", coinB.ToString());
        coinB = long.Parse(b);
        Debug.Log(pianoSpriteLevel);

    }

    public void DeleData()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }


    public void AddPlcoin()
    {
        if (audioS == 0)
        {
            if(isMain == true)
            {
                beforeAudioVolum = loadaudio.volume;
                loadaudio.volume = loadaudio.volume / 10;

            }

            Debug.Log(beforeAudioVolum);
            audioS++;
        }
        if (recorderStack == 16)
        {
            recorderStack = 0;
        }
        if (isTriangle == false)
        {
            clickAct = true;
        }

        if (isDosh == false)
        {
            plCoin += Rpc;
        }
        else if(isDosh == true)
        {
            Rpc *= 2;
            plCoin += Rpc;
        }
         
        
        audioSource.clip = audioRecorder[recorderStack];

        if(isMain == true)
        {
            audioSource.Play();
        }
        
        if(isMain == true)
        {
            if(isMain == false)
            {
                return;
            }
            ClickAnimation();
        }

        if(isMain == true)
        {
            if (isMain == false)
            {
                return;
            }
            ClickTextPrint(Rpc, ObjectType.moneyText);
        }

        if(isMain == true)
        {
            if (isMain == false)
            {
                return;
            }
            ClickPrint(ObjectType.clickEffect);
        }

        UpdateText();




        timeInt = 0;

        recorderStack++;
        SaveData();
    }

    public void tabClick()
    {
        ClickPrint(ObjectType.clickEffect);
    }



    private void Update()
    {

        if (RamanAmount != 0)
        {
            Raman.SetActive(true);
        }
        if (TriangleAmount != 0)
        {
            Triangle.SetActive(true);
        }
        if (DoshiAmount != 0)
        {
            Doshirac.SetActive(true);
        }
        if (BreadAmount != 0)
        {
            Bread.SetActive(true);
        }
        if (DrinkAmount != 0)
        {
            Drink.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            ClickPrint(ObjectType.clickEffect);
        }

        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            RpsTu();

        }

        if(isTriangle == true)
        {
            if(Time.time > andTime)
            {
                andTime = Time.time + TimeRIg;
                AddPlcoin();
                Debug.Log("응애");
            }
        }

        if (plCoin < 0)
        {
            plCoin = 0;
        }
        if (recorderStack != 15)
        {
            Rpc = ((RpcLevel1*100)+(RpcLevel2*2000)+(RpcLevel3*3000)+(RpcLevel4*4000)+(RpcLevel5*5000)+(RpcLevel6*6000)+(RpcLevel7*7000)+(RpcLevel8*8000)+(RpcLevel9*9000)+(RpcLevel10*10000) + 10)*3;
        }
        else if(recorderStack == 15)
        {
            Rpc = ((RpcLevel1*100 + (RpcLevel2 * 2000) + (RpcLevel3 * 3000) + (RpcLevel4 * 4000) + (RpcLevel5 * 5000) + (RpcLevel6 * 6000) + (RpcLevel7 * 7000) + (RpcLevel8 * 8000) + (RpcLevel9 * 9000) + (RpcLevel10 * 10000) + 10) * 6 + micLevel*1000 * micLevel)*2 ;
        }
        

        if (clickAct == true)
        {
            timeInt += Time.deltaTime;
            if(timeInt >= 3)
            {
                OffAct();
            }
        }
    }

    private void OffAct()
    {
        clickAct = false;
        recorderStack = 0;
        timeInt = 0;
        audioS = 0;
        Debug.Log("offAct");
        Debug.Log(loadaudio.volume*10);
        Debug.Log(beforeAudioVolum);
        loadaudio.volume = beforeAudioVolum;
        Debug.Log(beforeAudioVolum);
    }



    private void ClickAnimation()
    {
        if (clickAct == true)
        {
            playerImage.transform.DOScale(new UnityEngine.Vector2(-1, -1), 0.5f);
            playerImage.transform.DOScale(new UnityEngine.Vector2(1, 1), 0.5f);

        }

    }

    private void ClickTextPrint(long coin,ObjectType type)
    {
       
        GameObject MeshText = poolManager.PoolPlayObject(type);
        Transform txtTransform = MeshText.transform;
        MeshText.gameObject.SetActive(true);
        

        UnityEngine.Vector3  mouspos;
        mouspos = Input.mousePosition;
        transpos = Camera.main.ScreenToWorldPoint(mouspos);

        MeshText.transform.position = new UnityEngine.Vector3(transpos.x, transpos.y, 0);

        if (recorderStack == 15)
        {
            MeshText.transform.localScale = new UnityEngine.Vector3(1.5f, 1.5f, 0);
        }

        StartCoroutine(MeshTextCool(MeshText,type));
     
    }

    public void TextSizeSet(GameObject meshText, Transform meshTransform)
    {
        meshText.transform.localScale = meshTransform.transform.localScale;
    }

    public void TextAnimating(TextMeshPro meshText, float colorspeed)
    {
        meshText.DOColor(new Color(meshText.color.r, meshText.color.g, meshText.color.b, 0), colorspeed);
        
    }

    private IEnumerator MeshTextCool(GameObject MeshText,ObjectType type)
    {
        yield return new WaitForSeconds(1f);
        poolManager.CoolObject(MeshText, type);
    }

    private void RpsTu()
    {
        if (isRaman == false)
        {
            RpsA = 1 + (pianoLevel * drumLevel * micLevel * flutLevel * tamLevel) * 2;
        }
        else if(isRaman == true)
        {
            RpsA = (1 + (pianoLevel * drumLevel * micLevel * flutLevel * tamLevel) * 2)*10;
        }
        
        Debug.Log(RpsA);
        plCoin += RpsA;
        UpdateText();
        
    }

    private void ClickPrint(ObjectType type)
    {
        if(isMain == false)
        {
            return;
        }
        UnityEngine.Vector3 mouspos;
        mouspos = Input.mousePosition;
        transpos = Camera.main.ScreenToWorldPoint(mouspos);

       

        GameObject clickEffect = poolManager.PoolPlayObject(type);
        GameObject Particleobj = poolManager.PoolPlayObject(ObjectType.effectPart);

        ParticleSystem part = Particleobj.GetComponent<ParticleSystem>();

        clickEffect.gameObject.SetActive(true);
        Particleobj.gameObject.SetActive(true);

        Particleobj.transform.position = new UnityEngine.Vector3(transpos.x, transpos.y, 0);
        clickEffect.transform.position = new UnityEngine.Vector3(transpos.x, transpos.y, 0);


        StartCoroutine(MeshTextCool(clickEffect, type));
        StartCoroutine(MeshTextCool(Particleobj, ObjectType.effectPart));
    }

    private void UpdateText()
    {
        BigInteger renderNum = plCoin;
        BigInteger defalt = 0;

        int stack = 0;

        if (renderNum < 1000)
        {
            coinTxt.text = renderNum.ToString();
            return;
        }

        for(int i = 0; i<unit.Length; ++i)
        {
            if (renderNum >= 1000)
            {
                defalt = renderNum % 1000;
                renderNum /= 1000;
                ++stack;
            }
            else
            {
                if (defalt > 100)
                {
                    coinTxt.text = renderNum.ToString() + "." + defalt + unit[stack];
                    break;
                }
                else if (defalt > 10)
                {
                    coinTxt.text = renderNum.ToString() + "." + "0" + defalt + unit[stack];
                    break;
                }
                else if (defalt < 10)
                {
                    coinTxt.text = renderNum.ToString() + "." + "00" + defalt + unit[stack];
                    break;
                }
                else if (defalt == 100)
                {
                    coinTxt.text = renderNum.ToString() + "." + "1" + unit[stack];
                    break;
                }
                else if (defalt == 10)
                {
                    coinTxt.text = renderNum.ToString() + "." + "01" + unit[stack];
                    break;
                }
            }
            
        }

       
    }
}
