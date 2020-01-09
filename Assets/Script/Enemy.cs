using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    float speed1 = 1f;
     public float number;
     bool widze = false;
   
    void Start()
    {
         number = Random.Range (-15f, 15f);
         transform.Rotate(0, number, 0, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
         number= Random.Range (-60f, 60f);
        checkedges();
      // Debug.Log(widze);
        Collider[] hitColliders = Physics.OverlapSphere(transform.position,10);
        foreach(Collider hitCollider in hitColliders){
            if(hitCollider.name == "Player"){
            float step = speed1 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,GameObject.Find("Player").GetComponent<Transform>().position,step);
              //transform.Translate(GameObject.Find("Player").GetComponent<Transform>().position * Time.deltaTime * speed1);
             transform.LookAt(GameObject.Find("Player").GetComponent<Transform>().position);
             //   Vector3 newDirection = Vector3.RotateTowards(transform.position, GameObject.Find("Player").GetComponent<Transform>().position,step,0.0f);
              //  transform.rotation = Quaternion.LookRotation(newDirection);
            }
           else{
                   transform.Translate(Vector3.forward * Time.deltaTime * speed1);
            }

        }
    }
    public void checkedges(){
        bool edge = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down),2);
        if(edge==false){
            transform.Rotate(0, number, 0, Space.Self);
           
        }
         

    }

}
