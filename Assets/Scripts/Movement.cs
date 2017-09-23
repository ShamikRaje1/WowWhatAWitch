using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float sideSpeed;
    public float jumpSpeed;
    public float jumpDelay;
    public bool isJumping;
    float moveVertical;
    float moveHorizontal;
    int speed;

    void Start()
    {
        //You don't start jumping
        isJumping = false;
    }

    void FixedUpdate()
    {
        //Sets base x and y movement
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = GetComponent<Rigidbody2D>().velocity.y;

        //Makes the velocity vector that we'll use to edit the player later
        Vector3 velocity = new Vector3(moveHorizontal * sideSpeed, moveVertical, 0.0f);

        //If you press the up key to jump...
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Don't jump if you're already jumping
            if (!isJumping)
            {
                //Ok you can jump
                Debug.LogError("I tried");
                velocity.y = jumpSpeed;
                isJumping = true;
            }
        }

        //Setting player velocity to velocity
        //GetComponent<Rigidbody2D>().AddForce(velocity);
        GetComponent<Rigidbody2D>().velocity = velocity;

        //Flips the sprite as needed
        if (velocity.x > 0.1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        } else if (velocity.x < -0.1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        //Lets the animator know if the player is moving
        GetComponent<Animator>().SetFloat("Speed", Mathf.Abs(velocity.x));

        
    }
}
