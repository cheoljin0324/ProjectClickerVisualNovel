using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Renderer>().sortingOrder = 2;
    }

}
