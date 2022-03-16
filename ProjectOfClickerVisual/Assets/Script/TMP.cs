using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class TMP : MonoBehaviour
{
    public float movespeed = 1f;
    public float colorspeed = 2f;
    TextMeshPro txt;

    private bool isColor = false;

    public long coin=0;
    public double OutCoin = 0;

    public Color txtColor;

    // Start is called before the first frame update
    void Start()
    {
        
        OutCoin = coin;


        GameManager.Inst.effectTextMesh.transform.position = new Vector3(GameManager.Inst.transpos.x, GameManager.Inst.transpos.y, 0);
        transform.position= new Vector3(GameManager.Inst.transpos.x, GameManager.Inst.transpos.y, 0);

        txt = GetComponent<TextMeshPro>();

        
        if (coin > 100000000)
        {
            OutCoin = coin / 100000000;
            txt.text = OutCoin.ToString() + "��";
        }
        else if (coin > 10000)
        {
            OutCoin = coin / 10000;
            txt.text = OutCoin.ToString() + "��";
        }
        else
        {
            txt.text = OutCoin.ToString();
        }
        txtColor = txt.color;

        Debug.Log(txt.color);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, movespeed * Time.deltaTime, 0));
        txt.DOColor(new Color(txt.color.r, txtColor.g, txtColor.b, 0), colorspeed);
        DestroyOb();
    }

    void DestroyOb()
    {
        Destroy(gameObject, colorspeed);
    }
}
