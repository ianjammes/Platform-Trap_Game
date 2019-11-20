using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenCube4 : MonoBehaviour
{

    public GameObject invisiblePlatform;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<Renderer>().enabled = true;
            invisiblePlatform.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
