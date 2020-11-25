using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidModel : MonoBehaviour, IDamage
{
    public float speed;

    public Quaternion angularRot;

    public Vector3 _scale;

    public float health = 100f;

    private void Start()
    {
        transform.localScale = _scale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SpaceShip")
        {    
            Destroy(gameObject);
        }
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

    public void Impact(float damage)
    {
        if (transform.position.y < 4.5f)
        {
            health -= damage;

            if (health <= 0f)
            {
                Debug.Log("Астероид уничтожен");
                Destroy(gameObject);
            }
        }
    }
}
