using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandFinale : MonoBehaviour
{
    public Player _player;
    public Cam _camera;
    public GameObject _fade;
    public GameObject _key;
    public Timer _timer;
    public GameObject star;
    public GameObject enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            _fade.SetActive(true);
            _player._control._states = ControlStates.EscapeFromSlowliness;
            StartCoroutine(FadeIn());
        }
    }

    IEnumerator FadeIn()
    {

        _player.transform.position = star.transform.position;
        _camera.ChangeColor();
        yield return new WaitForSeconds(1);
        _timer.timeText.gameObject.SetActive(true);
        _timer.timerIsRunning = true;
        // start Timer
        _key.SetActive(true);
        _player._control._states = ControlStates.Moving;
        _fade.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        enemy.SetActive(true);
    }
}
