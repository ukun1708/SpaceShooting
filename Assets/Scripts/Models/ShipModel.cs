using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipModel : MonoBehaviour
{
    public float speed = 1f;

    public float speedRotation = 300f;

    public float firingDelay = 1f;

    public BulletModel bullet_Prefab;

    public Transform shootingPivot;
}
