using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatePlatform3 : MonoBehaviour
{

    [SerializeField] private Animator myAnim;

    private void OnCollisionEnter2D(Collision2D other) //when we jump off the platform
    {
        if (other.gameObject.tag == ("Player"))
        {
            StartCoroutine(wait());
            myAnim.SetBool("playPlatform3", true);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
    }
}
