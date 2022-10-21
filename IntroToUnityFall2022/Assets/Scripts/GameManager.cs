using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0; 

    public void BirdDies()
    {
        Debug.Log("Bird Dies");

        Time.timeScale = 0; 
    }

    public void scorePoint()
    {
        score += 1; 
        Debug.Log(score);
    }
}
