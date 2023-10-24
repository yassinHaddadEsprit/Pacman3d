using UnityEngine;

public class MangerPiece : MonoBehaviour
{
    public int valeurPiece = 1; // D�finissez la valeur d'une pi�ce
    

    

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