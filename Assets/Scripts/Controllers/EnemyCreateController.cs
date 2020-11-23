using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreateController : MonoBehaviour
{
    public LevelSetting setting;

    private float time = 0f;
    
    void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time > setting.createDelay)
        {
            Vector3 CreatePos = new Vector3(Random.Range(-2f, 2f), 10f, -1f);

            GameObject asteroid = Instantiate(setting.asteroidModel.gameObject, CreatePos, Quaternion.identity);

            var model = asteroid.GetComponent<AsteroidModel>();

            float randScale = Random.Range(setting.asteroidScaleMin, setting.asteroidScaleMax);

            model._scale = new Vector3(randScale, randScale, randScale);

            model.speed = Random.Range(setting.speedMin, setting.speedMax) / randScale;

            var x = Random.Range(setting.randomRotMin, setting.randomRotMax) / randScale;

            var y = Random.Range(setting.randomRotMin, setting.randomRotMax) / randScale;

            var z = Random.Range(setting.randomRotMin, setting.randomRotMax) / randScale;

            model.angularRot = Quaternion.Euler(x, y, z);

            
            
            time = 0f;

        } 
    }
}
