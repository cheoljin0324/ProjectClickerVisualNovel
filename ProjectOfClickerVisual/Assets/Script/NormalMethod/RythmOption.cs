using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RythmOption : MonoBehaviour
{
    [SerializeField]
    private Image[] imageBuutton;
    [SerializeField]
    private Sprite[] spriteButton;
    [SerializeField]
    private GameObject SaveRememberWindow;
    [SerializeField]
    private GameObject mainCanvas;
    [SerializeField]
    private GameObject RythmObject;

    [SerializeField]
    private Transform contentTransform;

    private bool isRythm = false;
    private int playingStack = 0;
    int stack = 0;

    private bool isBoolPlay = false;
    private bool isSave = false;


    private int stack1 = 0;
    private int stack2 = 0;
    private int stack3 = 0;
    private int stack4 = 0;
    private int stack5 = 0;
    private int stack6 = 0;
    private int stack7 = 0;
    private int stack8 = 0;
    private int stack9 = 0;
    private int stack10 = 0;
    private int stack11 = 0;
    private int stack12 = 0;
    private int stack13 = 0;
    private int stack14 = 0;
    private int stack15 = 0;
    private int stack16 = 0;

    private bool audioshift = false;

    private void Awake()
    {
        LoadStack();

    }

    private void Start()
    {
        if (stack1 > 7) stack1 = 7;
        if (stack2 > 7) stack2 = 7;
        if (stack3 > 7) stack3 = 7;
        if (stack4 > 7) stack4 = 7;
        if (stack5 > 7) stack5 = 7;
        if (stack6 > 7) stack6 = 7;
        if (stack7 > 7) stack7 = 7;
        if (stack8 > 7) stack8 = 7;
        if (stack9 > 7) stack9 = 7;
        if (stack10 > 7) stack10 = 7;
        if (stack11 > 7) stack11 = 7;
        if (stack12 > 7) stack12 = 7;
        if (stack13 > 7) stack13 = 7;
        if (stack14 > 7) stack14 = 7;
        if (stack15 > 7) stack15 = 7;
        if (stack16 > 7) stack16 = 7;
        GameManager.Inst.audioRecorder[0] = GameManager.Inst.recorderAudioData[stack1];
        GameManager.Inst.audioRecorder[1] = GameManager.Inst.recorderAudioData[stack2];
        GameManager.Inst.audioRecorder[2] = GameManager.Inst.recorderAudioData[stack3];
        GameManager.Inst.audioRecorder[3] = GameManager.Inst.recorderAudioData[stack4];
        GameManager.Inst.audioRecorder[4] = GameManager.Inst.recorderAudioData[stack5];
        GameManager.Inst.audioRecorder[5] = GameManager.Inst.recorderAudioData[stack6];
        GameManager.Inst.audioRecorder[6] = GameManager.Inst.recorderAudioData[stack7];
        GameManager.Inst.audioRecorder[7] = GameManager.Inst.recorderAudioData[stack8];
        GameManager.Inst.audioRecorder[8] = GameManager.Inst.recorderAudioData[stack9];
        GameManager.Inst.audioRecorder[9] = GameManager.Inst.recorderAudioData[stack10];
        GameManager.Inst.audioRecorder[10] = GameManager.Inst.recorderAudioData[stack11];
        GameManager.Inst.audioRecorder[11] = GameManager.Inst.recorderAudioData[stack12];
        GameManager.Inst.audioRecorder[12] = GameManager.Inst.recorderAudioData[stack13];
        GameManager.Inst.audioRecorder[13] = GameManager.Inst.recorderAudioData[stack14];
        GameManager.Inst.audioRecorder[14] = GameManager.Inst.recorderAudioData[stack15];
        GameManager.Inst.audioRecorder[15] = GameManager.Inst.recorderAudioData[stack16];

        imageBuutton[0].sprite = spriteButton[stack1];
        imageBuutton[1].sprite = spriteButton[stack2];
        imageBuutton[2].sprite = spriteButton[stack3];
        imageBuutton[3].sprite = spriteButton[stack4];
        imageBuutton[4].sprite = spriteButton[stack5];
        imageBuutton[5].sprite = spriteButton[stack6];
        imageBuutton[6].sprite = spriteButton[stack7];
        imageBuutton[7].sprite = spriteButton[stack8];
        imageBuutton[8].sprite = spriteButton[stack9];
        imageBuutton[9].sprite = spriteButton[stack10];
        imageBuutton[10].sprite = spriteButton[stack11];
        imageBuutton[11].sprite = spriteButton[stack12];
        imageBuutton[12].sprite = spriteButton[stack13];
        imageBuutton[13].sprite = spriteButton[stack14];
        imageBuutton[14].sprite = spriteButton[stack15];
        imageBuutton[15].sprite = spriteButton[stack16];
        isSave = true;

    }

    public void SaveStack()
    {
        PlayerPrefs.SetInt("Stack1", stack1);
        PlayerPrefs.SetInt("Stack2", stack2);
        PlayerPrefs.SetInt("Stack3", stack3);
        PlayerPrefs.SetInt("Stack4", stack4);
        PlayerPrefs.SetInt("Stack5", stack5);
        PlayerPrefs.SetInt("Stack6", stack6);
        PlayerPrefs.SetInt("Stack7", stack7);
        PlayerPrefs.SetInt("Stack8", stack8);
        PlayerPrefs.SetInt("Stack9", stack9);
        PlayerPrefs.SetInt("Stack10", stack10);
        PlayerPrefs.SetInt("Stack11", stack11);
        PlayerPrefs.SetInt("Stack12", stack12);
        PlayerPrefs.SetInt("Stack13", stack13);
        PlayerPrefs.SetInt("Stack14", stack14);
        PlayerPrefs.SetInt("Stack15", stack15);
        PlayerPrefs.SetInt("Stack16", stack16);
        isSave = true;

    }

    private void LoadStack()
    {
        stack1 = PlayerPrefs.GetInt("Stack1", stack1);
        stack2 = PlayerPrefs.GetInt("Stack2", stack2);
        stack3 = PlayerPrefs.GetInt("Stack3", stack3);
        stack4 = PlayerPrefs.GetInt("Stack4", stack4);
        stack5 = PlayerPrefs.GetInt("Stack5", stack5);
        stack6 = PlayerPrefs.GetInt("Stack6", stack6);
        stack7 = PlayerPrefs.GetInt("Stack7", stack7);
        stack8 = PlayerPrefs.GetInt("Stack8", stack8);
        stack9 = PlayerPrefs.GetInt("Stack9", stack9);
        stack10 = PlayerPrefs.GetInt("Stack10", stack10);
        stack11 = PlayerPrefs.GetInt("Stack11", stack11);
        stack12 = PlayerPrefs.GetInt("Stack12", stack12);
        stack13 = PlayerPrefs.GetInt("Stack13", stack13);
        stack14 = PlayerPrefs.GetInt("Stack14", stack14);
        stack15 = PlayerPrefs.GetInt("Stack15", stack15);
        stack16 = PlayerPrefs.GetInt("Stack16", stack16);


    }



    public void UpRythm1(int rythm)
    {
        ++stack1;
        if (stack1 == 8)
        {
            stack1 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack1];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack1];
        isSave = false;
    }
    public void UpRythm2(int rythm)
    {
        ++stack2;
        if (stack2 == 8)
        {
            stack2 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack2];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack2];
        isSave = false;
    }
    public void UpRythm3(int rythm)
    {
        ++stack3;
        if (stack3 == 8)
        {
            stack3 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack3];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack3];
        isSave = false;
    }
    public void UpRythm4(int rythm)
    {
        ++stack4;
        if (stack4 == 8)
        {
            stack4 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack4];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack4];
        isSave = false;
    }
    public void UpRythm5(int rythm)
    {
        ++stack5;
        if (stack5 == 8)
        {
            stack5 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack5];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack5];
        isSave = false;
    }
    public void UpRythm6(int rythm)
    {
        ++stack6;
        if (stack6 == 8)
        {
            stack6 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack6];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack6];
        isSave = false;
    }
    public void UpRythm7(int rythm)
    {
        ++stack7;
        if (stack7 == 8)
        {
            stack7 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack7];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack7];
        isSave = false;
    }
    public void UpRythm8(int rythm)
    {
        ++stack8;
        if (stack8 == 8)
        {
            stack8 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack8];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack8];
        isSave = false;
    }
    public void UpRythm9(int rythm)
    {
        ++stack9;
        if (stack9 == 8)
        {
            stack9 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack9];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack9];
        isSave = false;
    }
    public void UpRythm10(int rythm)
    {
        ++stack10;
        if (stack10 == 8)
        {
            stack10 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack10];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack10];
        isSave = false;
    }
    public void UpRythm11(int rythm)
    {
        ++stack11;
        if (stack11 == 8)
        {
            stack11 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack11];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack11];
        isSave = false;
    }
    public void UpRythm12(int rythm)
    {
        ++stack12;
        if (stack12 == 8)
        {
            stack12 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack12];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack12];
        isSave = false;
    }
    public void UpRythm13(int rythm)
    {
        ++stack13;
        if (stack13 == 8)
        {
            stack13 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack13];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack13];
        isSave = false;
    }
    public void UpRythm14(int rythm)
    {
        ++stack14;
        if (stack14 == 8)
        {
            stack14 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack14];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack14];
        isSave = false;
    }
    public void UpRythm15(int rythm)
    {
        ++stack15;
        if (stack15 == 8)
        {
            stack15 = 0;
        }

        imageBuutton[rythm].sprite = spriteButton[stack15];
        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack15];
        isSave = false;
    }
    public void UpRythm16(int rythm)
    {
        ++stack16;
        if (stack16 == 8)
        {
            stack16 = 0;
        }
        imageBuutton[rythm].sprite = spriteButton[stack16];

        GameManager.Inst.audioRecorder[rythm] = GameManager.Inst.recorderAudioData[stack16];
        isSave = false;
    }

    public void PlayAudio() { 
    
        
        playingStack = 0;
        if (isBoolPlay == true)
        {
            isBoolPlay = false;
            StopCoroutine("PlayAudioEngien");
            GameManager.Inst.audioSource.Stop();
            GameManager.Inst.audioSource.clip = GameManager.Inst.audioRecorder[0];
            playingStack = 0;
            GameManager.Inst.loadaudio.volume = GameManager.Inst.beforeAudioVolum;
        }

        else if (isBoolPlay == false)
        {
            isBoolPlay = true;
            GameManager.Inst.beforeAudioVolum = GameManager.Inst.loadaudio.volume;
            GameManager.Inst.loadaudio.volume = GameManager.Inst.loadaudio.volume / 10;
            StartCoroutine("PlayAudioEngien");
        }

        
       
       
    }

    IEnumerator PlayAudioEngien()
    {
        while (playingStack<16)
        {
            if (audioshift == true)
            {
                GameManager.Inst.audioSource.Stop();
                audioshift = false;
                GameManager.Inst.audioSource.volume = 1f;
                GameManager.Inst.loadaudio.volume = GameManager.Inst.beforeAudioVolum;
                break;
            }
            if (isBoolPlay == false)
            {
                break;
            }
            GameManager.Inst.audioSource.clip = GameManager.Inst.audioRecorder[playingStack];
            GameManager.Inst.audioSource.Play();

            if (playingStack == 16)
            {
                GameManager.Inst.audioSource.Stop();
                audioshift = false;
                GameManager.Inst.audioSource.volume = 1f;
                GameManager.Inst.loadaudio.volume = GameManager.Inst.loadaudio.volume = GameManager.Inst.beforeAudioVolum;
                break;
            }
            playingStack++;
            yield return new WaitForSeconds(0.5f);
        }

    }

    public void OnEixtWindow()
    {
        if (isSave == false)
        {
            SaveRememberWindow.SetActive(true);
        }
        else if (isSave == true)
        {
            RythmObject.SetActive(false);
            mainCanvas.SetActive(true);
            audioshift = true;
            contentTransform.position = new Vector3(contentTransform.position.x, 0, 0);
        }
    }

    public void SaveExit()
    {
        SaveStack();
        mainCanvas.SetActive(true);
        RythmObject.SetActive(false);
        audioshift = true;
        contentTransform.position = new Vector3(contentTransform.position.x, 0, 0);
    }

    public void OutExit()
    {
        
        mainCanvas.SetActive(true);
        RythmObject.SetActive(false);
        audioshift = true;
        contentTransform.position = new Vector3(contentTransform.position.x, 0, 0);
    }


}
