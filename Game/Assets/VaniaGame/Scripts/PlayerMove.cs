using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //create rigib body to add physics to the object
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
    //always initialize a variable to the rigid body    
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * 5;
        float v = Input.GetAxis("Vertical") * 5;

        Vector3 vel = rb.velocity;
        vel.x = -h;
        vel.z = -v;
        rb.velocity = vel;



    }
}
