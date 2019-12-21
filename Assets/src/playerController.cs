using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerController : MonoBehaviour
{


    //movement variables
    public static float maxSpeed;
    private Transform trans;
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

    static bool collided;

    private Transform originalTransform;

    private static int numberTimesLost = 5;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        anim = GetComponent<Animator>();

        checkPointManager _varLastCheckPoint = FindObjectOfType<checkPointManager>();

        if(numberTimesLost == 1)
        {
            trans.position = _varLastCheckPoint.startPosition;
        }
        else
        {
            trans.position = _varLastCheckPoint.lastCheckpoint;
        }





        //trans.position = cpManager.lastCheckpoint; //Position to reappear after death
        //Debug.Log(cpManager.lastCheckpoint);

        maxSpeed = 16.0f;
}

void FixedUpdate()
    {

        anim.SetFloat("speed", Mathf.Abs(move));

        move = Input.GetAxis("Horizontal"); //for using it with the computer keyboard


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
            if(numberTimesLost == 1)
            {
                numberTimesLost = 5;
            }
            else
            {
                numberTimesLost--;
            }
           // Debug.Log(numberTimesLost);
        }

        //Setting diferent levels of jumping, the more you hold the more you jump
        //if (Input.GetKey(KeyCode.Space) && isJumping == true) //desktop
        if (isPressed && isJumping == true) //mobile
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

        //if (Input.GetKeyUp(KeyCode.Space)) //desktop
        if (isPressed == false) //mobile
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
            //if (Input.GetKeyDown(KeyCode.Space)) //desktop
            if (isPressed) //mobile
            {
                isJumping = true;
                jumpTimeCounter = jumpTime;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }

        if(other.gameObject.layer == LayerMask.NameToLayer("MovingPlatform"))
        {
            transform.parent = other.transform; //player moving along with the platform
        }
    }

    //Not following the platform when not on it
    private void OnCollisionExit2D(Collision2D other)
    {
        transform.parent = originalTransform;
    }

    public void flip()
    {
        facingRight = !facingRight;
        Vector3 characterScale = transform.localScale;
        characterScale.x *= -1;
        transform.localScale = characterScale;
    }

    public void walkingRight()
    {
        move = 1f;
     }

    public void walkingLeft()
    {
        move = -1f;
    }

    public void notWalking()
    {
        move = 0f;
    }

    public void jumping()
    {
        isPressed = true;
        Invoke("notJumping", 0.5f); //can't jump right after touching ground
    }

    public void notJumping()
    {
        isPressed = false;
    }
}
