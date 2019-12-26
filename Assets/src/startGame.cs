using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startGame : MonoBehaviour
{
    private void OnMouseUp()
    {
        
    SceneManager.LoadScene("ImpossibleGame");
    }
}
