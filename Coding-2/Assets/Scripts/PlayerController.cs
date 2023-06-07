using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed=10.0f;
    public float xrange=10;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) Instantiate(projectile,transform.position,projectile.transform.rotation);
        if(transform.position.x<-xrange) transform.position=new Vector3(-xrange,transform.position.y,transform.position.z);
        if(transform.position.x>xrange) transform.position=new Vector3(xrange,transform.position.y,transform.position.z);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalInput*speed*Time.deltaTime);
    }
}
