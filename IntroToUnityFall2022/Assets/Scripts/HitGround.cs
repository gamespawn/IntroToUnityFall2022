using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGround : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager gm = GameObject.FindObjectOfType<GameManager>(); 
        gm.BirdDies(); 
        //gm.restartGame();
    }
}
