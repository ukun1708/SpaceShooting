using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeSlider : MonoBehaviour
{
    Slider slider;

    public ShipModel ship;

    void Start()
    {
        slider = GetComponent<Slider>();

        slider.maxValue = ship.health;
        
    }

    private void Update()
    {
        slider.value = ship.health;
    }
}
