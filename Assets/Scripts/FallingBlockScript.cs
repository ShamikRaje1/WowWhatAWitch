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
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        if (other.transform.CompareTag("Death"))
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update () {

    }
}
