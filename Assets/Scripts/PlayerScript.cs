using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Globals;


public class PlayerScript : MonoBehaviour

{

    private Rigidbody2D rb;
    private bool isGrounded;
    private Animator anim;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GameObject player;
    
       
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        DoJump();
        DoMove();
        DoShoot();

    }

    void DoJump()
    {
        Vector2 velocity = rb.velocity;

        // check for jump
        if (Input.GetKey("space") && (isGrounded == true))

        {
            if (velocity.y < 0.00f)
            {
                velocity.y = 10f;

            }
        }

        rb.velocity = velocity;

    }

    void DoMove()
    {
        Vector2 velocity = rb.velocity;


        velocity.x = 0;

        // move left with "a"
        if (Input.GetKey("a"))
        {
            velocity.x = -10;
        }

        //move right with "d"
        if (Input.GetKey("d"))
        {
            velocity.x = 10;
        }
        rb.velocity = velocity;

        //flips sprite
        if (velocity.x < -0.5f)
        {

            Helper.FlipSprite(gameObject, Left);
        }
        if (velocity.x > 0.5f)
        {
            Helper.FlipSprite(gameObject, Right);
        }

        if (velocity.x == 0)
        {
            anim.SetBool("walk", false);
        }
        else
        {
            anim.SetBool("walk", true);
        }

       

        /*if (velocity.y == 0)
        {
            anim.SetBool("jumping", false);
        }
        else
        {
            anim.SetBool("jumping", true);
        }*/


    }
    void DoShoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            float x = transform.position.x;
            float y = transform.position.y;

            // get direction of player
            Helper.GetObjectDir(player);
            Helper.MakeBullet(bulletPrefab, x, y, 6, 0);


            

            
            
        }      

                                
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
    
    



}

