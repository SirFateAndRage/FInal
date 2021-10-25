using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingBell : MonoBehaviour
{
    public Animator bell;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            bell.SetBool("beel", true);
            Destroy(this.gameObject);

        }
       

    }
}
