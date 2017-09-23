using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBlocks : MonoBehaviour {
    public const float UPPER_LIMIT = 6;
    public const float LOWER_LIMIT = 1.5f;
    public GameObject fallBlock;
    private float x;
    public float y;
    private int rand;
    public float rangeMax;
    private float timer = 0;
    private float offset;
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
            x = Random.Range(LOWER_LIMIT, UPPER_LIMIT);
            offset = Random.Range(-0.2f, 0.2f);
            Instantiate(fallBlock, new Vector2(x+offset, y), Quaternion.identity);
            Instantiate(fallBlock, new Vector2(-x, y), Quaternion.identity);
            timer = 0;
        }
	}
}
