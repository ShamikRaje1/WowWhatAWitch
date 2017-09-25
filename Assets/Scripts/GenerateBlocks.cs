using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateBlocks : MonoBehaviour {
    public const float UPPER_LIMIT = 6;
    public const float LOWER_LIMIT = 1.5f;
    public GameObject fallBlock;
    public Text score;
    private float x;
    public float y;
    private int rand;
    public float rangeMax;
    private float timer = 0;
    public int numOfBlocks = 0;

    public Sprite Bee;
    public Sprite Lady;
    public Sprite Leaf;

    //    private const Sprite RIGHT_LIMIT = new 
    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        rand = (int)Random.Range(0, rangeMax);
        timer += Time.deltaTime;
//        Debug.Log(timer);
        if (rand == 1 && timer > 1)
        {
            x = Random.Range(-UPPER_LIMIT, UPPER_LIMIT);
            Instantiate(fallBlock, new Vector2(-x, y), Quaternion.identity);

            float choose = Random.Range(1, 4);
            Sprite square;

            if (choose == 1)
            {
                square = Bee;
            } else if (choose == 2)
            {
                square = Lady;
            } else
            {
                square = Leaf;
            }

            fallBlock.GetComponent<SpriteRenderer>().sprite = square;
            numOfBlocks++;
            timer = 0;
            score.text = "Score: " + numOfBlocks.ToString();
        }
	}
}
