using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour


{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //I want to make the enemy look at the player.
        //I want to make the enemy walk.

        DoLookAtPlayer();

    }


    void DoLookAtPlayer()
    {
        float px = player.transform.position.x;
        float ex = transform.position.x;

        if (ex > px)
        {
            DoFaceLeft(true);
        }
        else
        {
            DoFaceLeft(false);
        }


    }


    void DoFaceLeft(bool faceLeft)
    {
        if (faceLeft == true)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

    }







}
