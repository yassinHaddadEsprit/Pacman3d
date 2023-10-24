using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Instance statique pour un accès facile

    public int nombrePieces = 0; // Variable pour compter les pièces
    public Text textePieces; // Référence au texte d'affichage du nombre de pièces

    void Awake()
    {
        if (instance == null)
            instance = this;
        
    }

  

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
        textePieces.text = "Pieces: " + nombrePieces ;
        
    }
}

