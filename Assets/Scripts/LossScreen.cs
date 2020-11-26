using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossScreen : MonoBehaviour
{
    public ShipModel ship;

    public GameObject lossScreen;

    public GameObject WinScreen;

    void Start()
    {
        lossScreen.SetActive(false);

        WinScreen.SetActive(false);
    }

    
    void Update()
    {
        if (ship.health <= 0)
        {
            Debug.Log("Вы проиграли");
            StartCoroutine(LossPop());
        }

        if (AsteroidCounter.Singleton.countAsteroid >= 20)
        {
            Debug.Log("Вы выиграли");
            StartCoroutine(WinPop());
        }

    }

    IEnumerator LossPop()
    {
        yield return new WaitForSeconds(1f);

        lossScreen.SetActive(true);

        yield return null;
    }

    IEnumerator WinPop()
    {
        yield return new WaitForSeconds(1f);

        WinScreen.SetActive(true);

        yield return null;
    }
}
