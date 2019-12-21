using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public GameObject checkPoint1;
    public bool isTriggered;

    void Awake()
    {
        DontDestroyOnLoad(checkPoint1);
        isTriggered = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            isTriggered = true;
        }
    }


}
