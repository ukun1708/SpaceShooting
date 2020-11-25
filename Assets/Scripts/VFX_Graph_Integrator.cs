using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFX_Graph_Integrator : MonoBehaviour
{
    private VisualEffect visual;

    public ShipModel ship;
    void Start()
    {
        visual = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        visual.SetVector3("TransformTarget", transform.position = ship.transform.position);

        if (ship.health == 100)
        {
            visual.SetFloat("ParticleCount", 0f);
        }

        if (ship.health <= 50)
        {
            visual.SetFloat("ParticleCount", 50f);
        }

        if (ship.health <= 0)
        {
            StartCoroutine(Boom());
        }
    }

    IEnumerator Boom()
    {
        visual.SetFloat("Radius_0", 3f);
        visual.SetFloat("Radius_1", 3f);
        visual.SetFloat("Height", 2f);
        visual.SetFloat("ParticleCount", 10000f);        

        yield return new WaitForSeconds(1f);

        visual.SetFloat("ParticleCount", 0f);
        visual.SetFloat("Radius_0", 0.36f);
        visual.SetFloat("Radius_1", 0.13f);
        visual.SetFloat("Height", 1f);

        visual.Stop();

        yield return null;
    }
}
