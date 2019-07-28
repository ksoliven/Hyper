using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarScript : MonoBehaviour
{
    private int starAmount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        { 
        Destroy(gameObject);
        ScoreTextScript.starAmount += 1;
        }
    }
     void OnLevelWasLoaded(int level)
    {
        ScoreTextScript.starAmount = 0;    
    }

}
