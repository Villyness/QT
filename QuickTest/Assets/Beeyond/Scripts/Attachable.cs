using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attachable : MonoBehaviour
{
    public GameObject ObjectToAttachTo;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Trigger>().Landing += Attach;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Attach(Vector3 AttachPos)
    {
        transform.position = AttachPos;
        this.transform.parent = ObjectToAttachTo.transform;
    }
}
