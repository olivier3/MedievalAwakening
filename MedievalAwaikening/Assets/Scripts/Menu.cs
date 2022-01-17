using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text textDifficulte;
    // Start is called before the first frame update
    void Start()
    {
        textDifficulte.text = $"Difficultée choisie : {InfoJoueur.difficulte}";
    }
    void Update()
    {
        textDifficulte.text = $"Difficultée choisie : {InfoJoueur.difficulte}";
    }
    public void BoutonJouer()
    {
        InfoJoueur.bossVivant = true;
        SceneManager.LoadScene("Niveau1");
    }
    public void BoutonQuitter()
    {
        Application.Quit();
    }
    public void BoutonNormal()
    {
        InfoJoueur.difficulte = "Normal";
    }
    public void BoutonMortel()
    {
        InfoJoueur.difficulte = "Mortel";
    }
}