﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerController : MonoBehaviour
{


    //movement variables
    public float maxSpeed;
    private Rigidbody2D rb;
    private Animator anim;
    private bool facingRight;
    private float move = 0f;

    //jump movements
    public float jumpForce = 5f;
    public float jumpTime;
    private float jumpTimeCounter;
    private bool isJumping;

    private bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal"); //for using it with the computer keyboard

        anim.SetFloat("speed", Mathf.Abs(move));

        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        //Fliping the player the right way
        if (move > 0 && facingRight)
        {
            flip();
        }
        else if (move < 0 && !facingRight)
        {
            flip();
        }

        //Detecting if we fall and the game is over
        if(rb.transform.position.y < -20)
        {
            SceneManager.LoadScene("ImpossibleGame"); //reload the scene
        }

        //Setting diferent levels of jumping, tjhe more you hold the more you jump
        if (/*isPressed*/Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (/*isPressed == false*/Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }

    //checking if we are on the ground
    void OnCollisionStay2D (Collision2D other)
    {
        if (other.gameObject.tag == "Ground") //checking if we're touching the ground
        {
            //allowing it to jump
            if (/*isPressed*/Input.GetKeyDown(KeyCode.Space))
            {
                isJumping = true;
                jumpTimeCounter = jumpTime;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }



            transform.parent = other.transform; //player moving along with the platform
        }
    }

    public void flip()
    {
        facingRight = !facingRight;

        Vector3 characterScale = transform.localScale;
        characterScale.x *= -1;
        transform.localScale = characterScale;

    }

    public void moveLeft()
    {
        move = -1f;
    }

    public void moveRight()
    {
        move = 1f ;
    }

    public void moveNeutral()
    {
        move = 0f;
    }

    public void jumping()
    {
        isPressed = true;
    }

    public void notJumping()
    {
        isPressed = false;
    }
}