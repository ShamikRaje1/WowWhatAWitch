using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    

    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        var Player = GameObject.Find("Player");
        Player.GetComponent<Movement>().isJumping = false;
        Player.GetComponent<Movement>().flutterTime = 0;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        var Player = GameObject.Find("Player");
        Player.GetComponent<Movement>().isJumping = true;
    }
    

    
}
