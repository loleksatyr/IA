using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    float speed = 5f;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up* speed, ForceMode.Impulse );
        }
        */
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.right * speed;
            // rb.velocity = transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.D))

        {
            rb.velocity = -transform.right * speed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = -transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = transform.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down),1))
            rb.AddForce(transform.up * speed, ForceMode.Impulse);
            
        }

    }
     void OnCollision(Collision collision)
    {
        if (collision.gameObject.name == "EndPoint")
        {
            Elevator.active = false;
        }
    }
}
