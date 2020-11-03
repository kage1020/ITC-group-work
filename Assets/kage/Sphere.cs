﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody.AddForce(velocity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
