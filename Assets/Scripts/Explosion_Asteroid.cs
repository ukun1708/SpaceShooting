using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
public class Explosion_Asteroid : MonoBehaviour
{
    public VisualEffect effect;

    public static Explosion_Asteroid Singleton;

    void Start()
    {
        Singleton = this;

        effect = GetComponent<VisualEffect>();

        effect.Stop();

        effect.enabled = true;
    }

    public void Boom()
    {
        StartCoroutine(DestroyAsteroid());
    }
    IEnumerator DestroyAsteroid()
    {
        effect.Play();
        effect.SetFloat("RadiusExlposion", 0.5f);

        yield return new WaitForSeconds(0f);

        effect.SetFloat("RadiusExlposion", 0f);
        effect.Stop();
        
        yield return null;
    }
}
