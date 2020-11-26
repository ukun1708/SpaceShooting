using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipModel : MonoBehaviour
{
    public float speed = 1f;

    public float speedRotation = 300f;

    public float firingDelay = 1f;

    public int health = 100;

    public BulletModel bullet_Prefab;

    public Transform shootingPivot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy_asteroid")
        {
            damageShip();

            Explosion_Asteroid.Singleton.Boom();

            Explosion_Asteroid.Singleton.transform.position = gameObject.transform.position;

            if (health <= 0)
            {
                FiringController.Singleton.fire = false;

                gameObject.SetActive(false);

                Explosion.Singleton.Explode();

                Debug.Log("Корабль уничтожен");
                
            }
        }        
    }

    void damageShip()
    {
        health -= 30;
    }
}

