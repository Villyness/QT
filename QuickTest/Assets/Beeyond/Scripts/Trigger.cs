using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Trigger : MonoBehaviour
{
    public event Action<Vector3> Landing;
    public Vector3 OwnPos;

    void Start()
    {
        OwnPos = transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Landing(OwnPos);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Landing(OwnPos);
        }
        Debug.Log("Hello World");
    }
}
