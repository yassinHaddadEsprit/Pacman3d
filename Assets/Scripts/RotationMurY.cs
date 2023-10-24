using UnityEngine;

public class RotationMurY : MonoBehaviour
{
    public float vitesseRotation = 1.0f; // Vitesse de rotation du mur (en degrés par seconde)

    void Update()
    {
        transform.Rotate(Vector3.up, vitesseRotation * Time.deltaTime);
    }
}