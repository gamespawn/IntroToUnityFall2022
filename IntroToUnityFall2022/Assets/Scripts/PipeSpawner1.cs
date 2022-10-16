using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner1 : MonoBehaviour
{
    public GameObject pipes;
    public float time = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( time > 3 )
        {
            var temp = Instantiate(pipes, transform.position, transform.rotation);
            time = 0; 
            Destroy(temp, 3f);
        }
        else 
        {
            time += Time.deltaTime; 
        }
    }
}
