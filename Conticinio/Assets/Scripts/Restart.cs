using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public Vector3 _initialPos;
    public Player _player;
    public GameObject star;
    public GameObject _fade;
    public AllSouls _allsouls;
    public Rigidbody2D _rb;
    void Start()
    {
        _initialPos = this.transform.position;
        _rb = GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            _fade.SetActive(true);
            _player._control._states = ControlStates.EscapeFromSlowliness;
            StartCoroutine(FadeIn());

        }

    }
    IEnumerator FadeIn()
    {
        _allsouls.moving = false;
        _allsouls.transform.position = _allsouls._initialPos;
        _player.transform.position = star.transform.position;
        yield return new WaitForSeconds(0.5f);
        _fade.SetActive(false);
        _rb.isKinematic = true;
        transform.position = _initialPos;
        _player._control._states = ControlStates.Moving;
        _allsouls.moving = true;
      

    }
}
