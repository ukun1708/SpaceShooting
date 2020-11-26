using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringController : MonoBehaviour
{
    public ShipModel ship;

    private float time = 0f;

    public bool fire = true;

    public static FiringController Singleton;
    void Start()
    {
        Singleton = this;

        fire = true;
    }


    void Update()
    {
        time += Time.deltaTime;

        if (time > ship.firingDelay)
        {
            if (Input.GetMouseButton(0))
            {
                if (fire == true)
                {
                    var bullet = Instantiate(ship.bullet_Prefab.gameObject, ship.shootingPivot.position, Quaternion.identity);

                    time = 0f;
                }
                
            }

        }
    }
}
