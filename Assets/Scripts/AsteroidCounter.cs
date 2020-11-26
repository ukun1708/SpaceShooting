using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidCounter : MonoBehaviour
{
    Text textCount;

    public int countAsteroid = 0;

    public static AsteroidCounter Singleton;
    void Start()
    {
        Singleton = this;

        textCount = GetComponent<Text>();
    }

    
    void Update()
    {
        textCount.text = countAsteroid.ToString() + "/20";
    }
}
