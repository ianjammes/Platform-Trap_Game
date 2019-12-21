using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointManager : MonoBehaviour
{

    public checkPointManager cpManager;
    public Vector3 lastCheckpoint;
    public checkPoint cp1;


    // Start is called before the first frame update
    void Awake()
    {
        //lastCheckpoint = new Vector3(-277, -9, 0);
        DontDestroyOnLoad(cpManager);
    }

    // Update is called once per frame
    void Update()
    {   
        if (cp1.isTriggered == true)
        {
            lastCheckpoint = cp1.transform.position;
        }
    }
}
