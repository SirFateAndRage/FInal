using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public DialogueManager dial;
    public CuestionController cuestion;
    public DialogueUI diaui;
    public GameObject _player;

 

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        dial._cuestionController = cuestion;
        dial.dialUi = diaui;
        dial.player = _player;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
