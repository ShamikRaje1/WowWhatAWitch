using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlockScript : MonoBehaviour {
    public string side;
	// Use this for initialization
	void Start () {
        if (gameObject.transform.position.y <= 0)
        {
            side = "Left";
        }
        else
        {
            side = "Right";
        }
        gameObject.GetComponent<Rigidbody2D>().sharedMaterial.friction = 3;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Death"))
        {
            Destroy(gameObject);
        }
        else if (other.transform.CompareTag("Stick"))
        {
            Debug.Log("Web Hit");
            gameObject.GetComponent<Rigidbody2D>().sharedMaterial.friction *= 80.0f;
            Debug.Log(gameObject.GetComponent<Rigidbody2D>().sharedMaterial.friction);
        }
    }

    //public void OnCollisionEnter2D(Collision2D coll)
    //{
    //    if (coll.gameObject.transform.tag == "Stick")
    //    {
    //        gameObject.GetComponent<Rigidbody2D>().sharedMaterial.friction += 80.0f;
    //        Debug.Log(gameObject.GetComponent<Rigidbody2D>().sharedMaterial.friction);
    //    }
    //}
    // Update is called once per frame
    void Update () {

    }
}
