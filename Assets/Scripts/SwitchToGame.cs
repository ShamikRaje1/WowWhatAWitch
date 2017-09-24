using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void SwitchToMain()
    {
        SceneManager.LoadSceneAsync("main", LoadSceneMode.Single);
    }
    public void SwitchToEnd()
    {
        SceneManager.LoadSceneAsync("GameOver", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
