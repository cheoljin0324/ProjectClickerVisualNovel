using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMP : MonoBehaviour
{
    public float movespeed = 1f;
    public float colorspeed = 2f;
    TextMeshPro txt;

   

    public long coin=0;
    public double OutCoin = 0;

    private int destroyTime = 2;

    Color txtColor;

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
            txt.text = OutCoin.ToString() + "¾ï";
        }
        else if (coin > 10000)
        {
            OutCoin = coin / 10000;
            txt.text = OutCoin.ToString() + "¸¸";
        }
        else
        {
            txt.text = OutCoin.ToString();
        }
        txtColor = txt.color;
        Invoke("DestroyTxt", destroyTime);
        
    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, movespeed * Time.deltaTime, 0));
        txtColor.a = Mathf.Lerp(txtColor.a, 0, Time.deltaTime * colorspeed);
        txt.color = txtColor;
    }

    private void DestroyTxt()
    {
        Destroy(gameObject);
    }
}
