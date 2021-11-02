using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject Victory;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Victory.SetActive(true);
        Time.timeScale = 0;
        
    }
}
