using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjectTest : MonoBehaviour
{

    [SerializeField]
    private GameObject PrefsObejct;

    public void ObjectGeneRate()
    {
        Instantiate(PrefsObejct);
    }
}
