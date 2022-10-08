using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown("Fire1") )
        {
            Debug.Log("Bird Jump");
            //this.gameObject.transform.position += new Vector3(0, 1, 0);
            //rb.AddForce(new Vector2(0, 500));
            rb.velocity = new Vector2(0, 5);
        }
    }
}
