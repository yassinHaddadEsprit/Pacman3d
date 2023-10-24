using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public AudioSource soundEffect;  
    public float speed = 5.0f;

    private void Start()
    {

    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    public void Die()

    {
        Destroy(gameObject);
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="CollisionTag")
        {
            soundEffect.Play();
        }
    }

}

