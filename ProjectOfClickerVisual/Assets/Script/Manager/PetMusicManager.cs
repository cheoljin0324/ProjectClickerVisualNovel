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
    private Sprite[] flutSprites = null;

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
    private Image flutImage = null;
    
    

  

    private void  Start()
    {
        GameManager.Inst.LoadData();

        if (GameManager.Inst.pianoLevel != 0)
        {
            pianoImage.gameObject.SetActive(true);
            pianoImage.sprite = pianoSprites[GameManager.Inst.pianoSpriteLevel];       
        }

        if(GameManager.Inst.drumLevel != 0)
        {
            drumImage.gameObject.SetActive(true);
            drumImage.sprite = drumSprites[GameManager.Inst.drumSpriteLevel];
        }

        if(GameManager.Inst.micLevel != 0)
        {
                micImage.gameObject.SetActive(true);
                micImage.sprite = micSprites[GameManager.Inst.micSpriteLevel];
        }
        if(GameManager.Inst.flutLevel != 0)
        {
            flutImage.gameObject.SetActive(true);
            flutImage.sprite = flutSprites[GameManager.Inst.flutSpriteLevel];
        }
        if(GameManager.Inst.tamLevel != 0)
        {
            tamImage.gameObject.SetActive(true);
            tamImage.sprite = tamSprites[GameManager.Inst.tamSpriteLevel];
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
        GameManager.Inst.micLevel += 1;
        if (GameManager.Inst.micLevel > 10 && GameManager.Inst.micLevel % 10 == 0)
        {
            GameManager.Inst.micSpriteLevel += 1;
        }
        GameManager.Inst.plCoin -= GameManager.Inst.micMoney;
        GameManager.Inst.micMoney = (GameManager.Inst.micLevel * GameManager.Inst.micLevel * 2) + 1;

        if (GameManager.Inst.micSpriteLevel == 0)
        {
            micImage.gameObject.SetActive(true);
            micImage.sprite = micSprites[GameManager.Inst.micSpriteLevel];
        }
        if (micImage.sprite != micSprites[GameManager.Inst.micSpriteLevel])
        {
            micImage.sprite = micSprites[GameManager.Inst.micSpriteLevel];
        }



        GameManager.Inst.SaveData();
    }

    public void DrumUpdate()
    {
        GameManager.Inst.drumLevel += 1;
        if (GameManager.Inst.drumLevel > 10 && GameManager.Inst.drumLevel % 10 == 0)
        {
            GameManager.Inst.drumSpriteLevel += 1;
        }
        GameManager.Inst.plCoin -= GameManager.Inst.drumMoney;
        GameManager.Inst.drumMoney = (GameManager.Inst.drumLevel * GameManager.Inst.drumLevel * 2) + 1;

        if (GameManager.Inst.drumSpriteLevel == 0)
        {
            drumImage.gameObject.SetActive(true);
            drumImage.sprite = drumSprites[GameManager.Inst.drumSpriteLevel];
        }
        if (drumImage.sprite != drumSprites[GameManager.Inst.drumSpriteLevel])
        {
            drumImage.sprite = drumSprites[GameManager.Inst.drumSpriteLevel];
        }
       
        GameManager.Inst.SaveData();
    }

    public void FlutUpdate()
    {
        GameManager.Inst.flutLevel += 1;
        if (GameManager.Inst.flutLevel > 10 && GameManager.Inst.flutLevel % 10 == 0)
        {
            GameManager.Inst.flutSpriteLevel += 1;
        }
        GameManager.Inst.plCoin -= GameManager.Inst.flutMoney;
        GameManager.Inst.flutMoney = (GameManager.Inst.flutLevel * GameManager.Inst.flutLevel * 2) + 1;

        if (GameManager.Inst.flutSpriteLevel == 0)
        {
            flutImage.gameObject.SetActive(true);
            flutImage.sprite = flutSprites[GameManager.Inst.flutSpriteLevel];
        }
        if (flutImage.sprite != flutSprites[GameManager.Inst.flutSpriteLevel])
        {
            flutImage.sprite = flutSprites[GameManager.Inst.flutSpriteLevel];
        }

        GameManager.Inst.SaveData();
    }

    public void tamUpdate()
    {
        GameManager.Inst.tamLevel += 1;
        if (GameManager.Inst.tamLevel > 10 && GameManager.Inst.tamLevel % 10 == 0)
        {
            GameManager.Inst.tamSpriteLevel += 1;
        }
        GameManager.Inst.plCoin -= GameManager.Inst.tamMoney;
        GameManager.Inst.tamMoney = (GameManager.Inst.tamLevel * GameManager.Inst.tamLevel * 2) + 1;

        if (GameManager.Inst.tamSpriteLevel == 0)
        {
            tamImage.gameObject.SetActive(true);
            tamImage.sprite = tamSprites[GameManager.Inst.tamSpriteLevel];
        }
        if (tamImage.sprite != tamSprites[GameManager.Inst.tamSpriteLevel])
        {
            tamImage.sprite = tamSprites[GameManager.Inst.tamSpriteLevel];
        }

        GameManager.Inst.SaveData();
    }


}
