using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeSlippery : MonoBehaviour
{
    public GameObject player;
    public GameObject slipperyPlatform;
    bool touching = false;

    private void Update()
    {
        if (touching == true)
        {
            //Debug.Log(touching);
            playerController.maxSpeed = 1.0f;

        }
        else{
            //Debug.Log(touching);

            playerController.maxSpeed = 15.0f;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touching = true;
        }
        
    }

    /*private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touching = false;
        }
    }*/
}
