using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPersonnage : MonoBehaviour
{
    public Animator animator;
    public float vitesse = 2;
    public bool isGrounded = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                position.x -= (vitesse + 2) * Time.deltaTime;
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsWalking", false);
            }
            else
            {
                position.x -= vitesse * Time.deltaTime;
                animator.SetBool("IsWalking", true);
                animator.SetBool("IsRunning", false);
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                position.x += (vitesse + 2) * Time.deltaTime;
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsWalking", false);
            }
            else
            {
                position.x += vitesse * Time.deltaTime;
                animator.SetBool("IsWalking", true);
                animator.SetBool("IsRunning", false);
            }
        }
        else
        {
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 275), ForceMode2D.Force);
            animator.SetTrigger("IsJumping");
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsRunning", false);
        }

        transform.position = position;
    }
}
