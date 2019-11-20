using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenCubeController : MonoBehaviour
{


    public GameObject cube2;
    public GameObject cube3;
    public GameObject cubeTrigger;

    // Start is called before the first frame update
    void Start()
    {
        cube2.SetActive(false);
        cube3.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cube2.SetActive(true);
            cube3.SetActive(true);
        }
    }

}
