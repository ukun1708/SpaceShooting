using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel : MonoBehaviour
{
    public float speed = 1f;

    public float damage = 100f;

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

    private void OnCollisionEnter(Collision collision)
    {
        IDamage damagebleObj;
        collision.gameObject.TryGetComponent<IDamage>(out damagebleObj);
        if (damagebleObj != null)
        {
            damagebleObj.Impact(damage);



            Destroy(gameObject);
        }
    }
}
