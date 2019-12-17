using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class enemyController : MonoBehaviour
{
    public float speed;
    public Transform groundDetection;
    private bool facingRight;
    [SerializeField] private Animator myAnim;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f); //raycast to down form where the object is

        if(groundInfo.collider == false)
        {
            if (facingRight)
            {
                transform.eulerAngles = new Vector2(0,-180);
                facingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector2(0, 0);
                facingRight = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            myAnim.SetBool("isDead", true);
        }
    }
}
