using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana2 : MonoBehaviour
{

    [SerializeField] private Animator myAnim;
    public GameObject banana;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            myAnim.SetBool("activateWall", true);
            banana.SetActive(false);

        }
    }
}
