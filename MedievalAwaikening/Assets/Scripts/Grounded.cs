using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Grounded : MonoBehaviour
{
    GameObject Hero;
    // Start is called before the first frame update
    void Start()
    {
        Hero = gameObject.transform.parent.gameObject;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision)
        {
            Hero.GetComponent<DeplacementPersonnage>().isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision)
        {
            Hero.GetComponent<DeplacementPersonnage>().isGrounded = false;
        }
    }
}