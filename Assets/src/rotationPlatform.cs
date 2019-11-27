using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationPlatform : MonoBehaviour
{

    [SerializeField] private Animator myAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            myAnim.SetBool("playPlatform9", true);
        }
    }
}
