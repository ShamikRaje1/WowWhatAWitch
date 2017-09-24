using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float sideSpeed;
    public float jumpSpeed;
    public float jumpDelay;
    public bool isJumping;
    public float flutter;
    public GameObject projectile;
    public float shotVelocity;
    float moveVertical;
    float moveHorizontal;
    int speed;
    private float xVelSign = 1;
    private int bulletNum = 0;
    private float doublePrevTimer = 0;

    void Start()
    {
        //You don't start jumping
        isJumping = false;
    }
    public void ShootWeb()
    {
        GameObject bullet = Instantiate(projectile, new Vector2(gameObject.transform.position.x + xVelSign*0.75f, gameObject.transform.position.y), Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xVelSign*shotVelocity, 0.0f);
    }
    void FixedUpdate()
    {
        doublePrevTimer += Time.deltaTime;
       // Debug.Log(doublePrevTimer);
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
                velocity.y = jumpSpeed;
                isJumping = true;
                GetComponent<Rigidbody2D>().gravityScale = 3;
            }

            if (GetComponent<Rigidbody2D>().velocity.y < 0)
            {
                GetComponent<Rigidbody2D>().gravityScale = flutter;
            }
            else
            {
                GetComponent<Rigidbody2D>().gravityScale = 3;
            }
        } else
        {
            GetComponent<Rigidbody2D>().gravityScale = 3;
        }
        // shoots web ball
        if (Input.GetKeyDown(KeyCode.Z) && doublePrevTimer > 0.15)
        {
   //         Debug.Log("SHOOTING!");
            ShootWeb();
            doublePrevTimer = 0;
        }
        //Setting player velocity to velocity
        //GetComponent<Rigidbody2D>().AddForce(velocity);
        GetComponent<Rigidbody2D>().velocity = velocity;

        //Flips the sprite as needed
        if (velocity.x > 0.1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            xVelSign = 1;
        } else if (velocity.x < -0.1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            xVelSign = -1;
        }

        //Lets the animator know if the player is moving
        GetComponent<Animator>().SetFloat("Speed", Mathf.Abs(velocity.x));

        
    }
}
