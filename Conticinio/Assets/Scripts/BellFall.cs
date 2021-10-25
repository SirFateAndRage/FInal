using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellFall : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            _rb.isKinematic = false;
            Destroy(this.gameObject);
        }
    }
}
