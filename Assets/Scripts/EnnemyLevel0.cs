using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnnemyLevel0 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();

        if (player != null)
        {
            player.Die();
            SceneManager.LoadScene("LostLevel0");

        }
    }
}
