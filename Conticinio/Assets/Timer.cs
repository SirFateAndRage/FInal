using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    public GameObject Derrota;

    public void Start()
    {
        timeText.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (timerIsRunning)
        {
            DisplayTime(TimeRemaining);
            if (TimeRemaining > 0)
            {
                TimeRemaining -= Time.deltaTime;
            }
            else
            {
                // endlevel
                TimeRemaining = 0;
                timerIsRunning = false;
                Derrota.SetActive(true);
                timeText.gameObject.SetActive(false);
                Time.timeScale = 0;

            }

        }
      
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
