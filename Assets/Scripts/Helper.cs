using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
	
	public static void FlipSprite(GameObject obj, bool flipLeft)
	{
		
        if( flipLeft == true )
        {
			obj.transform.localRotation = Quaternion.Euler(0, 180, 0);
		}
		else
        {
			obj.transform.localRotation = Quaternion.Euler(0, 0, 0);
		}


	
		/*public static void FollowPlayer(player.transform.position.x, float followPlayer)
    
		if(followPlayer)
		{
			//enemy will look at the player
		}
        else
        {
			//enemy will look the othr way
        }*/


    }

		
}


