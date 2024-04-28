using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]
    float Destroy_time = 10;

    void Start()
    {

        Destroy(gameObject,Destroy_time);

    }

}
