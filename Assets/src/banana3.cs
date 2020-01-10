using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana3 : MonoBehaviour
{
    [SerializeField] private Animator player;
    public GameObject pinxos;
    public GameObject banana;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        banana2 _wallDown = FindObjectOfType<banana2>();

        if (collision.gameObject.tag == "Player" && _wallDown.wallDown==false)
        {
            Destroy(banana);
            player.SetBool("isDead", true);
        }
        else
        {
            Destroy(banana);
            Destroy(pinxos);
        }
    }
}
