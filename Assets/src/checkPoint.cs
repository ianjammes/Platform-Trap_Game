using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public GameObject checkPoint1;
    public bool isTriggered;
    private static int numberTimesLost = 5;

    void Start()
    {
        //DontDestroyOnLoad(checkPoint1);
        isTriggered = false;
        if (numberTimesLost == 1)
        {
            numberTimesLost = 5;
        }
        else
        {
            numberTimesLost--;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player") && numberTimesLost>1)
        {
            isTriggered = true;
        }
        else
        {
            isTriggered = false;
        }
    }


}
