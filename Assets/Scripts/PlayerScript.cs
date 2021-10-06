using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour

{

    private Rigidbody2D rb;
    private bool isGrounded;
    private Animator anim;
    public GameObject bulletPrefab;
    public Transform firePoint;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        DoJump();
        DoMove();
        DoYell();
        DoShoot();

        // this sets the variable to 10
        // From our condition we set up above we said that if "speed">5 then set the animation to "player_walk"


    }




    void DoJump()
    {
        Vector2 velocity = rb.velocity;

        // check for jump
        if (Input.GetKey("space") && (isGrounded == true))

        {
            if (velocity.y < 0.01f)
            {
                velocity.y = 7f;

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
            velocity.x = -5;
        }

        //move right with "d"
        if (Input.GetKey("d"))
        {
            velocity.x = 5;
        }
        rb.velocity = velocity;

        //flips sprite
        if (velocity.x < -0.5f)
        {

            Helper.FlipSprite(gameObject, true);
        }
        if (velocity.x > 0.5f)
        {
            Helper.FlipSprite(gameObject, false);
        }

        if (velocity.x == 0)
        {
            anim.SetBool("walk", false);
        }
        else
        {
            anim.SetBool("walk", true);
        }

        print("player x=" + velocity.x);

        if (velocity.y == 0)
        {
            anim.SetBool("jumping", false);
        }
        else
        {
            anim.SetBool("jumping", true);
        }


    }
    void DoShoot()
    {
        if (Input.GetButton("Fire1"))
        {
            float x = transform.position.x;
            float y = transform.position.y;

            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            rb.velocity = new Vector2(x, 0);

            // make bullet face correct direction

            // make bullet move in the direction the player is facing

            // have a go at making the bullet collide with something

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
    void DoYell()
    {
        print("help");
    }



}

