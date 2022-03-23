using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetMusicManager : MonoBehaviour
{
    [Header("스프라이트 그룹")]
    [SerializeField]
    private Sprite[] pianoSprites = null;
    [SerializeField]
    private Sprite[] micSprites = null;
    [SerializeField]
    private Sprite[] drumSprites = null;
    [SerializeField]
    private Sprite[] tamSprites = null;
    [SerializeField]
    private Sprite[] FlutSprites = null;

    [Header("이미지 그룹")]
    [SerializeField]
    private Image pianoImage = null;
    [SerializeField]
    private Image micImage = null;
    [SerializeField]
    private Image drumImage = null;
    [SerializeField]
    private Image tamImage = null;
    [SerializeField]
    private Image FlutImage = null;
    
    

  

    private void  Start()
    {

        Debug.Log("스프라이트레벨" + GameManager.Inst.pianoSpriteLevel);
        GameManager.Inst.LoadData();

        Debug.Log(GameManager.Inst.pianoSpriteLevel);

        if (GameManager.Inst.pianoLevel != 0)
        {
            pianoImage.gameObject.SetActive(true);
            pianoImage.sprite = pianoSprites[GameManager.Inst.pianoSpriteLevel];
            
        }

        if(GameManager.Inst.drumLevel != 0)
        {
            drumImage.gameObject.SetActive(true);
            if (GameManager.Inst.drumSpriteLevel != 0)
            {
                drumImage.sprite = drumSprites[GameManager.Inst.drumSpriteLevel];
            }
        }

        if(GameManager.Inst.micLevel != 0)
        {
            micImage.gameObject.SetActive(true);
            if (GameManager.Inst.micSpriteLevel!=0)
            {
                micImage.sprite = micSprites[GameManager.Inst.micSpriteLevel];

            }
        }


    }

    public void PianoUpdate()
    {
        

        GameManager.Inst.pianoLevel += 1;
        if (GameManager.Inst.pianoLevel>10&&GameManager.Inst.pianoLevel % 10 == 0)
        {
            GameManager.Inst.pianoSpriteLevel += 1;
        }
        GameManager.Inst.plCoin -= GameManager.Inst.pianoMoney;
        GameManager.Inst.pianoMoney = (GameManager.Inst.pianoLevel * GameManager.Inst.pianoLevel * 2) + 1;

        if (GameManager.Inst.pianoSpriteLevel == 0)
        {
            pianoImage.gameObject.SetActive(true);
            pianoImage.sprite = pianoSprites[GameManager.Inst.pianoSpriteLevel];
        }
        if (pianoImage.sprite != pianoSprites[GameManager.Inst.pianoSpriteLevel])
        {
            pianoImage.sprite = pianoSprites[GameManager.Inst.pianoSpriteLevel];
        }

    

        GameManager.Inst.SaveData();
    }
    public void MicUpdate()
    {
        if (GameManager.Inst.micSpriteLevel != 0)
        {
            pianoImage.gameObject.SetActive(true);
        }

        if (micImage.sprite != micSprites[GameManager.Inst.pianoSpriteLevel])
        {
            micImage.sprite = micSprites[GameManager.Inst.pianoSpriteLevel];
        }
        GameManager.Inst.micLevel += 1;
        GameManager.Inst.plCoin -= GameManager.Inst.micMoney;
        GameManager.Inst.micMoney = (GameManager.Inst.micLevel * GameManager.Inst.micLevel * 2) + 1;

        if (GameManager.Inst.drumLevel % 10 == 0)
        {
            GameManager.Inst.drumSpriteLevel += 1;
        }

        GameManager.Inst.SaveData();
    }

    public void DrumUpdate()
    {
        if (GameManager.Inst.drumSpriteLevel != 0)
        {
            pianoImage.gameObject.SetActive(true);
        }

        if (drumImage.sprite != drumSprites[GameManager.Inst.pianoSpriteLevel])
        {
            drumImage.sprite = drumSprites[GameManager.Inst.pianoSpriteLevel];
        }
        GameManager.Inst.drumLevel += 1;
        GameManager.Inst.plCoin -= GameManager.Inst.drumMoney;
        GameManager.Inst.drumMoney = (GameManager.Inst.drumLevel * GameManager.Inst.drumLevel * 2) + 1;

        if (GameManager.Inst.micLevel % 10 == 0)
        {
            GameManager.Inst.micSpriteLevel += 1;
        }

        GameManager.Inst.SaveData();
    }

}
