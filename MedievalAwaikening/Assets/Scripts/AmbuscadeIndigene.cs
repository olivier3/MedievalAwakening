using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbuscadeIndigene : MonoBehaviour
{
    private bool direction = true;
    private readonly float vitesse = 2;
    private bool ambuscade = false;
    public AudioSource crie;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ambuscade)
        {
            Vector2 position = transform.position;

            GetComponent<SpriteRenderer>().enabled = true;

            if (direction)
            {
                GetComponent<SpriteRenderer>().flipX = false;
                position.x += vitesse * Time.deltaTime;
            }
            if (!direction)
            {
                GetComponent<SpriteRenderer>().flipX = true;
                position.x -= vitesse * Time.deltaTime;
            }

            transform.position = position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Mur"))
        {
            direction = !direction;
        }

        if (collision.transform.CompareTag("Hero"))
        {
            ambuscade = true;
            crie.Play();
        }
    }
}
