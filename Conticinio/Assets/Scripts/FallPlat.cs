using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
    Rigidbody2D _rb;
    Animator _anim;
    [SerializeField] float timeToWait;
    [SerializeField] float TimeToRespawn;
    Vector3 _initialpos;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _initialpos = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
            Invoke("DropPlat", 0.5f);

    }

  void DropPlat()
  {
        _rb.isKinematic = false;
        StartCoroutine(Restart());
  }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(timeToWait);
        _anim.SetBool("Vanish", true);
        yield return new WaitForSeconds(timeToWait);
        _rb.isKinematic = true;
        transform.position = _initialpos;
        _anim.SetBool("Vanish", false);


    }
}
