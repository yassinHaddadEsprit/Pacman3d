using UnityEngine;
using UnityEngine.UI;

public class GameManageer : MonoBehaviour
{
    public static GameManager instance; // Instance statique pour un acc�s facile

    public int nombrePieces = 0; // Variable pour compter les pi�ces
    public Text textePieces; // R�f�rence au texte d'affichage du nombre de pi�ces

    

    void Start()
    {
        if (textePieces != null)
            textePieces.text = "Pieces: " + nombrePieces;
    }

    public void AjouterPiece(int valeur)
    {
        nombrePieces += valeur;
        if (textePieces != null)
            textePieces.text = "Pieces: " + nombrePieces;
    }
    public void MettreAJourTextePieces()
    {
        textePieces.text = "Pieces: " + nombrePieces;
    }
}

