using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowerbound : MonoBehaviour
{
    private float bound = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < bound)
        {
            Destroy(gameObject); // Destroy(gameObject, 5); 5 is used for time of how much time after obj is destroyed
        }
    }
}
