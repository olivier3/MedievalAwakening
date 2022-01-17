using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MortSerpent : MonoBehaviour
{
    private GameObject Serpent;
    // Start is called before the first frame update
    void Start()
    {
        Serpent = gameObject.transform.parent.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Hero"))
        {
            if (Serpent.transform.CompareTag("SnakeBoss"))
            {
                InfoJoueur.bossVivant = false;
                Debug.Log("Boss mort");
            }
            Destroy(Serpent);
        }
    }
}
