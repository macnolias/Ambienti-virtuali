using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float Speed; // degrees per second

    //Update is called once per frame

    void Update()
    {

        transform.Rotate(0, Speed * Time.deltaTime, 0, Space.World);
    }
}
