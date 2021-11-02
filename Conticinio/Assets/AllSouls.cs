using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSouls : MonoBehaviour
{
    public Vector3 _initialPos;
    public Player _player;
    public GameObject star;
    float speed = 3f;
    public bool moving;
    public GameObject _fade;
    private void Awake()
    {
        _initialPos = transform.position;
        moving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.position += transform.right * Time.deltaTime * speed;

        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
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
        moving = false;
        transform.position = _initialPos;
        _player.transform.position = star.transform.position;
        yield return new WaitForSeconds(1);
        _fade.SetActive(false);
        _player._control._states = ControlStates.Moving;
        moving = true;

    }
}
