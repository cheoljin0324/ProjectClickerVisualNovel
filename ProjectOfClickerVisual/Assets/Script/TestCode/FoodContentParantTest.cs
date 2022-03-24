using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodContentParantTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.SetParent(GameObject.Find("FoodContent").transform);
        gameObject.transform.localScale=(new Vector3(1f, 1f, 1f));
    }
}
