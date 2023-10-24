using UnityEngine;

public class DeplacementObstacleZ : MonoBehaviour
{
    public float amplitude = 10.0f;
    public float vitesse = 5.0f;

    private Vector3 startPosition;
    private bool vaEnArriere = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float deplacementZ = Mathf.Sin(Time.time * vitesse) * amplitude;

        if (vaEnArriere)
        {
            deplacementZ = -deplacementZ;
        }

        transform.position = startPosition + new Vector3(0.0f, 0.0f, deplacementZ);

        // Vérifiez si l'obstacle a atteint son amplitude maximale ou minimale, et stoppez-le si nécessaire
        if (deplacementZ >= amplitude || deplacementZ <= -amplitude)
        {
            vaEnArriere = !vaEnArriere;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mur"))
        {
            vaEnArriere = !vaEnArriere; // Inverse la direction lorsque l'obstacle entre en collision avec un mur
        }
        
    }
}
