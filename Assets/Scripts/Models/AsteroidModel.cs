﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidModel : MonoBehaviour
{
    public float speed;

    public Quaternion angularRot;

    public Vector3 _scale;

    private void Start()
    {
        transform.localScale = _scale;
    }

    private void Update()
    {        
        transform.rotation *= angularRot;

        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
        }
    }

}