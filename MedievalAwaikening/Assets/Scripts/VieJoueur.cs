using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VieJoueur : MonoBehaviour
{
    public int vieMax = InfoJoueur.pointDeVie;

    public int vieActuelle;

    public HealthBar barreDeVie;

    public float cpt = 0;

    private void Start()
    {
        if (InfoJoueur.difficulte == "Normal")
        {
            vieActuelle = vieMax;
            barreDeVie.SetMaxVie(vieActuelle);
        }
        else
        {
            vieActuelle = vieMax - 81;
            barreDeVie.SetVie(vieActuelle);
        }
    }
    private void Update()
    {
        if (vieActuelle <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        cpt += 1 * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("AttaqueEnnemi"))
        {
            Degat(20);
        }

        if (collision.transform.CompareTag("Water"))
        {
            SceneManager.LoadScene("Niveau1");
        }

        if (collision.transform.CompareTag("Vide"))
        {
            SceneManager.LoadScene("Niveau2");
        }
    }

    void Degat(int degat)
    {
        if (cpt > 1)
        {
            cpt = 0;
            vieActuelle -= degat;
            barreDeVie.SetVie(vieActuelle);
        }
    }
}
