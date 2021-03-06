﻿using System;
using UnityEngine;


public class LockedCamera : CameraMode
{
    public Rigidbody followPlanet;
    public Rigidbody lookAtPlanet;
    public float distance;
    public float height;
    
    private void FixedUpdate()
    {
        Vector3 vector = followPlanet.position - lookAtPlanet.position;
        transform.position = followPlanet.position + (vector.normalized * distance) + (Vector3.up*height);
        transform.LookAt(lookAtPlanet.position);
    }
}