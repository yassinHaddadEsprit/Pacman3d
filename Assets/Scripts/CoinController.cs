using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinController : MonoBehaviour
{
    public static int coinsCollected = 0;
    public float vitesseRotation = 10.0f;

    void Update()
    {
        transform.Rotate(Vector3.up, vitesseRotation * Time.deltaTime);

    }
    void OnTriggerEnter(Collider other)
    {

        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Destroy(gameObject);
            coinsCollected++;
            CoinCounter.instance.IncreaseCoins();

            if (coinsCollected == 2)
            {
                SceneManager.LoadScene("WinLevel0");
                coinsCollected = 0;
            }
        }
    }

}