using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public float v ;
    public Rigidbody2D rb;
    public GameObject robot,re,rd;
    // Start is called before the first frame updat
    //Vector2 tempos;
    void Start()
    {
        robot = GameObject.Find("Robot");
        rb = robot.GetComponent<Rigidbody2D>();
        re = GameObject.Find("Roda1");
        rd = GameObject.Find("Roda2");
    }

    void Update()
    {
        
        //função ForceAtPosition
        if (Input.GetKey(KeyCode.A))
         {
            rb.AddForceAtPosition(re.transform.position,re.transform.forward*v); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForceAtPosition(rd.transform.position,rd.transform.forward * v);
          
        }
    }
}


