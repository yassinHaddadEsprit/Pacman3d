using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinController1 : MonoBehaviour
{
    public static int coinsCollected = 0;
    void OnTriggerEnter(Collider other)
    {

        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Destroy(gameObject);
            coinsCollected++;

            if (coinsCollected >= 3)
            {
                SceneManager.LoadScene("WinLevel1");
            }
        }
    }
}
