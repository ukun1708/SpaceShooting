using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel : MonoBehaviour
{
    public float speed = 1f;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.Self);

        if (transform.position.y > 10f)
        {
            Destroy(gameObject);
        }
    }
}
