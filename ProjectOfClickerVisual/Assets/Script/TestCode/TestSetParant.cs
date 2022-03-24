using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSetParant : MonoBehaviour
{
    [SerializeField]
    private GameObject testPrefs;
 
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(testPrefs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
