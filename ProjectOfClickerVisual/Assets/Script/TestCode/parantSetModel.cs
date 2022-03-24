using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parantSetModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.parent = GameObject.Find("ParantSet").transform;
    }

}
