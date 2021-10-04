using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour

{ 
    
    public GameObject player;
    

   
    void Start()
    {

    }

   
    void Update()
    {
        

        DoLookAtPlayer();



    }


    void DoLookAtPlayer()
    {
        float px = player.transform.position.x;
        float ex = transform.position.x;

        if (ex > px)
        {
            Helper.FlipSprite(gameObject, true);
        }
        else
        {
            Helper.FlipSprite(gameObject, false);
        }
    

    
       
    }

                 

}
