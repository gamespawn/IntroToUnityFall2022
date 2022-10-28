using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0; 
    public GameObject gameOverScreen;

    public void BirdDies()
    {
        Debug.Log("Bird Dies");

        Time.timeScale = 0; 
        gameOverScreen.SetActive(true);
    }

    public void scorePoint()
    {
        score += 1; 
        Debug.Log(score);
    }

    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
