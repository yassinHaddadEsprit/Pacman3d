using UnityEngine;

public class MangerPiece : MonoBehaviour
{
    public int valeurPiece = 1; // Définissez la valeur d'une pièce
    

    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            GameManager.instance.AjouterPiece(valeurPiece);
            GameManager.instance.MettreAJourTextePieces();
            Destroy(gameObject);
        }

    }
    

}