using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsOn : MonoBehaviour
{

    public Camera cam;
    public GameObject cube;
    public GameObject player;
    //int oldMask;

    // Start is called before the first frame update
    void Start()
    {
        //oldMask = camera.cullingMask;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cam.cullingMask = -1;
        }
    }
}
