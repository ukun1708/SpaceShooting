using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringController : MonoBehaviour
{
    public ShipModel ship;

    private float time = 0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        time += Time.deltaTime;

        if (time > ship.firingDelay)
        {
            if (Input.GetMouseButton(0))
            {
                var bullet = Instantiate(ship.bullet_Prefab.gameObject, ship.shootingPivot.position, Quaternion.identity);

                time = 0f;
            }
        }
    }
}
