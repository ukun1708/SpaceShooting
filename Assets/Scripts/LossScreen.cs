using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossScreen : MonoBehaviour
{
    public ShipModel ship;

    public GameObject lossScreen;

    void Start()
    {
        lossScreen.SetActive(false);
    }

    
    void Update()
    {
        if (ship.health <= 0)
        {
            StartCoroutine(LossPop());
        }
    }

    IEnumerator LossPop()
    {
        yield return new WaitForSeconds(1f);

        lossScreen.SetActive(true);

        yield return null;
    }
}
