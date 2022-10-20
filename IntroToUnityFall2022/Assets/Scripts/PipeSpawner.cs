using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePair; 
    private float timer = 0; 
    public float low;
    public float high;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(gameObject, position, rotation)
        float random = Random.Range(low, high);
        if ( timer > 3 )
        {
            var position = new Vector3(0f, random, 0);
            var temp = Instantiate(pipePair, position, transform.rotation);
            timer = 0; 
            Destroy(temp, 3f);
        }
        else
        {
            timer += Time.deltaTime; 
        }
    }
}
