using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager gm = GameObject.FindObjectOfType<GameManager>(); 
        gm.scorePoint(); 
    }
}
