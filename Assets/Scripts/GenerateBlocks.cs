using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBlocks : MonoBehaviour {
    public const float RIGHT_LIMIT = 6;
    public const float LEFT_LIMIT = -6;
    public GameObject fallBlock;
    private float x;
    public float y;
    private int rand;
    public float rangeMax;
    private float timer = 0;
    //    private const Sprite RIGHT_LIMIT = new 
    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        rand = (int)Random.Range(0, rangeMax);
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (rand == 1 && timer > 1)
        {
            x = Random.Range(0, RIGHT_LIMIT);
            Instantiate(fallBlock, new Vector2(x, y), Quaternion.identity);
            Instantiate(fallBlock, new Vector2(-x, y), Quaternion.identity);
            timer = 0;
        }
	}
}
