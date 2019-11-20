using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bananaScript : MonoBehaviour
{
    public GameObject banana;
    [SerializeField] private Animator myAnim;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(banana);
            myAnim.SetBool("isDead", true);
        }
    }
}
