using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana2 : MonoBehaviour
{

    [SerializeField] private Animator myAnim;
    [SerializeField] private Animator pinxos;
    public GameObject banana;
    private SpriteRenderer bn;
    public bool wallDown = false;

    private void Start()
    {
        //bn = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //bn.enabled = false;
            myAnim.SetBool("activateWall", true);
            pinxos.SetBool("activatePinxos", true);


            wallDown = true;

        }
    }
}
