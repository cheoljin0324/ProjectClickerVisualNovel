using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class TMP : MonoBehaviour
{
    public float movespeed = 1f;
    public float colorspeed = 4f;
    public bool inGame = false;
    TextMeshPro txt;

    private bool isColor = false;

    public long coin=0;
    public double OutCoin = 0;

    public Color txtColor;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, movespeed * Time.deltaTime, 0));

        
    }

    private void OnEnable()
    {
        if (inGame)
        {
            SetCoin();
            SetText();
            GameManager.Inst.TextAnimating(txt, colorspeed);
        }
        else
        {
            inGame = true;
        }
        
    }

    public void SetCoin()
    {
        OutCoin = GameManager.Inst.Rpc;
    }

    public void SetText()
    {


        GameManager.Inst.effectTextMesh.transform.position = new Vector3(GameManager.Inst.transpos.x, GameManager.Inst.transpos.y, 0);
        transform.position = new Vector3(GameManager.Inst.transpos.x, GameManager.Inst.transpos.y, 0);

        txt = GetComponent<TextMeshPro>();


        if (GameManager.Inst.Rpc > 100000000)
        {
            coin = GameManager.Inst.Rpc;
            OutCoin = coin / 100000000;
            txt.text = OutCoin.ToString() + "¾ï";
        }
        else if (GameManager.Inst.Rpc > 10000)
        {
            coin = GameManager.Inst.Rpc;
            OutCoin = coin / 10000;
            txt.text = OutCoin.ToString() + "¸¸";
        }
        else
        {
            OutCoin = GameManager.Inst.Rpc;
            txt.text = OutCoin.ToString();
        }
        txtColor = txt.color;

        Debug.Log(txt.color);

    }
}
