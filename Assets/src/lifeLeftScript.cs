using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeLeftScript : MonoBehaviour
{

    private static int numberTimesLost = 6;


    // Start is called before the first frame update
    void Start()
    {
        Text myTxt = GameObject.Find("lifeWidget/Text").GetComponent<Text>();
        

        if (numberTimesLost == 1)
        {
            numberTimesLost = 5;
        }
        else
        {
            numberTimesLost--;
        }
        myTxt.text = "x " + numberTimesLost;
    }
}
