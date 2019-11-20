using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectPlayerOnRock : MonoBehaviour
{

    [SerializeField] private Animator myAnim;

    private void OnCollisionExit2D(Collision2D other) //when we jump off the platform
    {
        if (other.gameObject.tag == ("Player"))
        {
            myAnim.SetBool("playPlatform1", true);
        }
    }
}
