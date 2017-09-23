﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float sideSpeed;
    public float jumpSpeed;
    public float jumpDelay;
    public bool isJumping;
    float moveVertical;
    float moveHorizontal;
    Rigidbody2D floor;

    void Start()
    {
        isJumping = false;
    }

    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = GetComponent<Rigidbody2D>().velocity.y;

        Vector3 velocity = new Vector3(moveHorizontal * sideSpeed, moveVertical, 0.0f);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isJumping)
            {
                return;
            }

            velocity.y = jumpSpeed;
            isJumping = true;
        }

        GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
