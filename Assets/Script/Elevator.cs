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
    bool down = false;
    bool wylo = true;
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
                wylo = false;
                Debug.Log("gora"); 
                
        }
            if(active)
            transform.Translate(Vector3.up * Time.deltaTime * speed1);
            if(down)
            transform.Translate(-Vector3.up * Time.deltaTime * speed1);
            Debug.Log(wylo);
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
            down  = true;
        }
 if (collision.gameObject.name == "StartPoint"&&wylo ==false)
        {
            active = true;
            Debug.Log("start");
            down  = false;
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
