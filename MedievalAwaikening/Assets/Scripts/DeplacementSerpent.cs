using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementSerpent : MonoBehaviour
{
    private bool direction = true;
    private readonly float vitesse = 1;

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Mur"))
        {
            direction = !direction;
        }
    }
}
