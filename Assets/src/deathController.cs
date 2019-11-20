using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathController : MonoBehaviour
{

    static int counter = 3;
    public Canvas tip;


    private void Start()
    {
        tip.enabled = false;
    }

    private void Update()
    {
        if(counter == 0)
        {
            StartCoroutine(ShowMessage());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            counter--;
            Debug.Log(counter);
        }
    }

    IEnumerator ShowMessage()
    {
        yield return new WaitForSeconds(1f);
        tip.enabled = true; 
        yield return new WaitForSeconds(5f);
        tip.enabled = false;
    }
}
