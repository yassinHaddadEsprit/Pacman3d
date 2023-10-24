using UnityEngine;

public class WallsY : MonoBehaviour
{
    public float amplitud = 10.0f;
    public float vitess = 5.0f;

    private Vector3 startPosition;
    private bool vaEnArrier = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float deplacementX = Mathf.Sin(Time.time * vitess) * amplitud;

        if (vaEnArrier)
        {
            deplacementX = -deplacementX;
        }

        transform.position = startPosition + new Vector3( 0.0f, deplacementX, 0.0f);


        if (deplacementX == amplitud || deplacementX == -amplitud)
        {
            vaEnArrier = !vaEnArrier;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");

        }
    }
}
