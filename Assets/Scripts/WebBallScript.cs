using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebBallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
