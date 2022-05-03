using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    // public float speed = 20f;
    public float turnSpeed=5;
    public float acclearation=5;
    public float horizontalInput;
    public float forwardInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal")*turnSpeed;
        forwardInput = Input.GetAxis("Vertical")*acclearation;
        // transform.Translate(0,0,(float) 0.1);
        transform.Translate(Vector3.forward*Time.deltaTime*forwardInput);
        // transform.Translate(Vector3.right*Time.deltaTime*horizontalInput);
        transform.Rotate(Vector3.up, horizontalInput*Time.deltaTime);

    }
}
