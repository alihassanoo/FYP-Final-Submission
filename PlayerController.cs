using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

  
    public float speed = 10F;
    public float turnSpeed = 30F;
    public float horizontalInput;

    private float xMin = -800.5f, xMax = 800.75f;

    
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed *horizontalInput);

        var pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, xMin, xMax);
        transform.position = pos;

    }
   
}
