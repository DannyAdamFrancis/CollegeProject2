using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Globals;


public class EnemyScript : MonoBehaviour

{ 
    
    public GameObject player;
    

   
    void Start()
    {

    }

   
    void Update()
    {
        

        DoLookAtPlayer();
        EnemyMove();


    }


    void DoLookAtPlayer()
    {
        float px = player.transform.position.x;
        float ex = transform.position.x;
        //helper script
        if (ex > px)
        {
            Helper.FlipSprite(gameObject, Left);
        }
        else
        {
            Helper.FlipSprite(gameObject, Right);
        }
                
       
    }
    
    void EnemyMove()    
    {

    }

                 

}
