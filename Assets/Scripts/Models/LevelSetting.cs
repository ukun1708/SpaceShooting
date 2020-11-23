using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelSetting", menuName = "Setting/LevelSetting", order = 1)]
public class LevelSetting : ScriptableObject
{
    public AsteroidModel asteroidModel;

    public float speedMin = 1f;

    public float speedMax = 5f;

    public float createDelay = 3f;

    public float randomRotMin = 1f;

    public float randomRotMax = 3f;

    public float asteroidScaleMin = 1f;

    public float asteroidScaleMax = 2f;
}
