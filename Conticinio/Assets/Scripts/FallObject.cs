using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] GameObject _fall;
    Vector3 _iniPos;

    void Start()
    {
        _iniPos = _fall.transform.position;

        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hola");
        if (collision.gameObject.layer == 10)
            Invoke("DropPlat", 0.5f);

    }
   public void DropPlat()
   {
        _rb.isKinematic = false;
        StartCoroutine(Restart());

    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(10);
        _rb.isKinematic = true;
        _fall.transform.position = _iniPos;
    }

   
}
