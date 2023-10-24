using System.Collections;
using UnityEngine;

public class ObstacleDynamique : MonoBehaviour
{
    public float amplitude = 1.0f; // Amplitude du mouvement
    public float vitesse = 1.0f;  // Vitesse du mouvement
    public bool deplacementSurX = true; // Est-ce que le mouvement se fait sur l'axe X ?

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        StartCoroutine(BougerObstacle());
    }


    IEnumerator BougerObstacle()
    {
        while (true)
        {
            float temps = Time.time * vitesse;
            float deplacement = Mathf.Sin(temps) * amplitude;

            if (deplacementSurX)
            {
                transform.position = startPosition + new Vector3(deplacement, 0.0f, 0.0f);
                if (deplacement > 0 ) {
                    transform.rotation = Quaternion.Euler(0, 90, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, -90, 0);
                }
                
            }
            else
            {
                transform.position = startPosition + new Vector3(0.0f, 0.0f, deplacement);
                if (deplacement > 0)
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                }
            }

            yield return null; // Attend la prochaine frame
        }
    }
}
