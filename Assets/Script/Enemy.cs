using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    float speed1 = 2f;
     public float number;

    void Start()
    {
         number= Random.Range (-60f, 60f);
         transform.Rotate(0, number, 0, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
         number= Random.Range (-60f, 60f);
         transform.Translate(Vector3.forward * Time.deltaTime * speed1);
        checkedges();
    }
    public void checkedges(){
        bool edge = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down),3);
        if(edge==false){
            transform.Rotate(0, number, 0, Space.Self);
            Debug.Log("log");
        }

    }
}
