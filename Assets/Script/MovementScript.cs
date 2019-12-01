using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
      [Range(1f,100f)][SerializeField] float movementSpeed = 1f;
    [SerializeField] float rotationSpeed = 1f;
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
       var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f * rotationSpeed;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f * movementSpeed;

            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down),1))
            rb.AddForce(transform.up * speed, ForceMode.Impulse);
            
        }

    }
   
}
