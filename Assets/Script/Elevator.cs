using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    // Start is called before the first frame update
    float speed1 = 1f;
    public static bool active;
    bool counter = false;
    bool nadol;
    
    void Start()
    {
        var spherec = GetComponent<Renderer>();
        spherec.material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
            if (counter)
            {
                StartCoroutine(Example());
                counter = false;
                Debug.Log("gora"); 
                
        }
            if(active)
            transform.Translate(Vector3.up * Time.deltaTime * speed1);

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("dzialaj");
        if (collision.gameObject.name == "Player")
        {
            counter = true;
        }
        if (collision.gameObject.name == "EndPoint")
        {
            active = false;
            Debug.Log("stop");
        }



    }
    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(2);
        active = true;
        print(Time.time);
    }
}
