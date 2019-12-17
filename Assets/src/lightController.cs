using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightController : MonoBehaviour
{

    public Camera camera;
    public GameObject cube;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            camera.cullingMask = (1 << LayerMask.NameToLayer("Nothing"));
        }
    }
}

