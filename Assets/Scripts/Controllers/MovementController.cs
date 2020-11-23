using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    public ShipModel ship;

    private float currentDelta;

    private float targetDelta;

    private float delta;
    void Start()
    {
        targetDelta = 0.5f;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            targetDelta = Input.mousePosition.x / Screen.width;
        }

        currentDelta = Mathf.Lerp(currentDelta, targetDelta, ship.speed * Time.deltaTime);

        delta = currentDelta - targetDelta;

        ship.transform.rotation = Quaternion.Euler(-90f, 0f, delta * ship.speedRotation);

        ship.transform.position = Vector3.Lerp(new Vector3(-2f, -3.5f, 0f), new Vector3(2f, -3.5f, 0f), currentDelta);
    }
}
