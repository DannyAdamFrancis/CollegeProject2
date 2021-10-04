using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour

{
  
    private Rigidbody2D rb;
    private bool isGrounded;
    private Animator anim;
    

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
                velocity.y = 7f;    // give the player a velocity of 5 in the y axis

            }
        }

        rb.velocity = velocity;

    }

    void DoMove()
    {
        Vector2 velocity = rb.velocity;

        // stop player sliding when not pressing left or right
        velocity.x = 0;

        // check for moving left
        if (Input.GetKey("a"))
        {
            velocity.x = -5;
        }

        // check for moving right
        if (Input.GetKey("d"))
        {
            velocity.x = 5;
        }
        rb.velocity = velocity;

        //changes the player direction when "a" or "d" are pressed
        if (velocity.x < -0.5f)
        {
            //DoFaceLeft(true);
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
        print("Full speed ahead");
    }

  

}

