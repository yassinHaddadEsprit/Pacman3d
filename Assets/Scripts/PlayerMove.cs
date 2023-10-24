using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    public float vitesse = 30.0f;
    private AudioSource eatCoin;
    

    void Update()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        float deplacementVertical = Input.GetAxis("Vertical");

        Vector3 deplacement = new Vector3(deplacementHorizontal, 0.0f, deplacementVertical) * vitesse * Time.deltaTime;
        Vector3 rotationInitiale = new Vector3(40.315f, -12.788f, -292.089f);

        RaycastHit hit;
        if (!Physics.Raycast(transform.position, deplacement, out hit, deplacement.magnitude))
        {
            transform.position += deplacement;
        }

        if (Mathf.Abs(deplacementHorizontal) > 0.1f || Mathf.Abs(deplacementVertical) > 0.1f)
        {
            Vector3 directionMouvement = new Vector3(deplacementHorizontal, 0, deplacementVertical).normalized;
            Quaternion rotationVersDirection = Quaternion.LookRotation(directionMouvement, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotationVersDirection, Time.deltaTime * 10f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {

            // Mettez ici le code pour détruire le joueur
            Destroy(gameObject);
        }
    }

}