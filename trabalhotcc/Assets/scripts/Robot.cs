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
        //funçao
        if (Input.GetKey(KeyCode.A))
         {
            //rb.AddForceAtPosition(re.transform.forward , re.transform.position * v, ForceMode2D.Force );

            //rb.AddForceAtPosition(re.transform.forward * 1.0f, re.transform.position );
            
             rb.AddForceAtPosition(rb .transform.forward * 10.0f, transform.position);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //rb.AddForceAtPosition(re.transform.forward , rd.transform.position * v, ForceMode2D.Force );

            //rb.AddForceAtPosition(rd.transform.forward * 1.0f, rd.transform.position );
          
            rb.AddForceAtPosition(rb.transform.forward * 10.0f, rd.transform.position);
        }
    }
}


