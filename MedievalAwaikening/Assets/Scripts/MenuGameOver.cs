using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void BoutonJouer()
    {
        InfoJoueur.bossVivant = true;
        SceneManager.LoadScene("Niveau1");
    }

    public void BoutonMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void BoutonQuitter()
    {
        Application.Quit();
    }
}
