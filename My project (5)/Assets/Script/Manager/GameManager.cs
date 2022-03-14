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
    private long Rpc = 0;
    [SerializeField]
    private Text coinTxt;

    [SerializeField]
    private GameObject TestError;

    [SerializeField]
    private RiCorderShopManager ricorderShop;

    public bool isTuto = false;
    
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
    private float nextTime = 0.0f;

    public int PianoLevel = 1;
    public int DrumLevel = 1;
    public int MicLevel = 1;


    [SerializeField]
    private int Rps = 0;

    [SerializeField]
    private Image playerImage;

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
        PlayerPrefs.SetInt("MicLevel", MicLevel);
        PlayerPrefs.SetInt("DrumLevel", DrumLevel);
        PlayerPrefs.SetInt("PianoLevel", PianoLevel);
    }

    public void LoadData()
    {
        string a;

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
        MicLevel = PlayerPrefs.GetInt("MicLevel", MicLevel);
        DrumLevel = PlayerPrefs.GetInt("DrumLevel", DrumLevel);
        PianoLevel = PlayerPrefs.GetInt("PianoLevel", PianoLevel);

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
            beforeAudioVolum = loadaudio.volume;
            loadaudio.volume = loadaudio.volume / 10;
            
            Debug.Log(beforeAudioVolum);
            audioS++;
        }
        if (recorderStack == 16)
        {
            recorderStack = 0;
        }
        clickAct = true;

      
            plCoin += Rpc;
        
        audioSource.clip = audioRecorder[recorderStack];
        audioSource.Play();
        ClickAnimation();
        ClickTextPrint(Rpc);
        ClickPrint();
        UpdateText();




        timeInt = 0;

        recorderStack++;
        SaveData();
    }

    public void tabClick()
    {
        ClickPrint();
    }



    private void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            ClickPrint();
        }

        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            RpsTu();


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
            Rpc = ((RpcLevel1*100 + (RpcLevel2 * 2000) + (RpcLevel3 * 3000) + (RpcLevel4 * 4000) + (RpcLevel5 * 5000) + (RpcLevel6 * 6000) + (RpcLevel7 * 7000) + (RpcLevel8 * 8000) + (RpcLevel9 * 9000) + (RpcLevel10 * 10000) + 10) * 6 + MicLevel*1000 * MicLevel)*2 ;
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
        loadaudio.volume = beforeAudioVolum;

        Debug.Log(beforeAudioVolum);
    }



    private void ClickAnimation()
    {
        playerImage.transform.DOScale(new UnityEngine.Vector2(-1, -1), 0.5f);
        playerImage.transform.DOScale(new UnityEngine.Vector2(1, 1), 0.5f);

    }

    private void ClickTextPrint(long coin)
    {
        GameObject MeshText = Instantiate(effectTextMesh);
        

        MeshText.GetComponent<TMP>().coin = coin;

        UnityEngine.Vector3  mouspos;
        mouspos = Input.mousePosition;
        transpos = Camera.main.ScreenToWorldPoint(mouspos);

        if (recorderStack == 15)
        {
            MeshText.transform.localScale = new UnityEngine.Vector3(1.5f, 1.5f, 0);
        }
     
    }

    private void RpsTu()
    {
        
        plCoin += 1 + (PianoLevel * PianoLevel* PianoLevel)*3;
        UpdateText();
        
    }

    private void ClickPrint()
    {
        UnityEngine.Vector3 mouspos;
        mouspos = Input.mousePosition;
        transpos = Camera.main.ScreenToWorldPoint(mouspos);

        GameObject clickEffect = Instantiate(effectClick);
        clickEffect.transform.position = transpos;


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
                coinTxt.text = renderNum.ToString()  + "." + defalt + unit[stack];
                break;
            }
            
        }

       
    }
}
