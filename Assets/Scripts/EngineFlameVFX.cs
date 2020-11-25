using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EngineFlameVFX : MonoBehaviour
{
    private VisualEffect visual;

    public ShipModel ship;
    
    void Start()
    {
        visual = GetComponent<VisualEffect>();
    }

    
    void Update()
    {
        visual.SetVector3("TransformTarget", transform.position = ship.transform.position);
    }
}
