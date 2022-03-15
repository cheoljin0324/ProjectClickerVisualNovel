using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType
{
    clickEffect,
    moneyText
}

[System.Serializable]
public class PoolInfo
{
    public ObjectType type;
    public int amount = 0;
    public GameObject Prfab = null;
    public GameObject container;

    [HideInInspector]
    public List<GameObject> pool = new List<GameObject>();
}

public class PoolManager : MonoBehaviour
{
    [SerializeField]
    List<PoolInfo> listofPool;

    private Vector3 defaltPos = new Vector3(-100, -100, -100);

    private void Start()
    {
        for(int i =0; i<listofPool.Count; i++)
        {
            FillPool(listofPool[i]);
        }
    }
    
    public void FillPool(PoolInfo poolInfo)
    {
        for(int i = 0; i<poolInfo.amount; i++)
        {
            GameObject objectInst = null;
            objectInst = Instantiate(poolInfo.Prfab, poolInfo.container.transform);
            objectInst.gameObject.SetActive(false);
            objectInst.transform.position = defaltPos;
            poolInfo.pool.Add(objectInst);
        }
    }

    //public GameObject GetPoolObject(ObjectType type)
    //{

    //}
}
