using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointManager : MonoBehaviour
{

    public checkPointManager cpManager;
    public Vector3 lastCheckpoint;
    public checkPoint cp1;
    public Vector3 startPosition;
    private static int numberTimesLost = 5;


    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(cpManager);
        if (numberTimesLost == 1)
        {
            numberTimesLost = 5;
        }
        else
        {
            numberTimesLost--;
        }
        Debug.Log(numberTimesLost);
    }

    // Update is called once per frame
    void Update()
    {   

        if (cp1.isTriggered == true && numberTimesLost>1)
        {
            lastCheckpoint = cp1.transform.position;
        }
        else
        {
            lastCheckpoint = startPosition;
        }

    }
}
