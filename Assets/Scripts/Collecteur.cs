using UnityEngine;

public class Collecteur : MonoBehaviour
{
    [SerializeField] private int objectif = 3;
    [SerializeField] private GameObject porteSortie;

    private int batteriesCollectees = 0;

    private void Start()
    {
        // TODO 1 : vérifier que la porte est assignée.
        if (porteSortie == null){
            Debug.LogError("La porte de sortie n'est pas assignée.");
        }
        // TODO 2 : cacher la porte au lancement du jeu.
        porteSortie.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO 3 : vérifier que l'objet touché est une batterie.
        if (!autre.CompareTag("Batterie")){
            return;
        }
        // TODO 4 : augmenter le compteur et afficher la progression.
        batteriesCollectees++;
        Debug.Log($"Batteries : {batteriesCollectees}/{objectif}");
        // TODO 5 : détruire uniquement la batterie touchée.
        Destroy(autre.gameObject);
        // TODO 6 : afficher la porte lorsque l'objectif est atteint.
        if (batteriesCollectees >= objectif){
            porteSortie.SetActive(true);
            Debug.Log("PORTE DÉVERROUILLÉE !");
        }
    }

    /*
     * BANQUE DE LIGNES — À REPLACER ET À INDENTER
     *
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * return;
     * 
     */
}

