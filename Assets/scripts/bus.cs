using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bus : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }
    float s = 10f;
    float turn = 20f;
    public float horixontal;
    public float vertical;
    // Update is called once per frame
    void Update()
    {
        movement();
        boundary();
        //movement2();



        }
    void movement()
    {
        horixontal = Input.GetAxis("Horizontal");
        vertical= Input.GetAxis("Vertical");
        //linear movement 
        /*  transform.Translate(Vector3.right * horixontal * Time.deltaTime * s);
          transform.Translate(Vector3.forward*vertical * Time.deltaTime * s);*/

        //roation mob=vement
        transform.Translate(Vector3.forward * vertical * Time.deltaTime * s);
        transform.Rotate(Vector3.up, horixontal * Time.deltaTime * turn);
       
    }
    void boundary()
    {
        
        if (transform.position.x > 8.5)
        {
            transform.position=new Vector3(8.5f,transform.position.y,transform.position.z);
        }
         if(transform.position.x< -7.5)
        {
            transform.position = new Vector3(-7.5f, transform.position.y, transform.position.z);
        }
    }
    void movement2()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * s * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * s * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * s * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(0, 0, 1);
            transform.Translate(Vector3.forward * s * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * Time.deltaTime);
        }


    }


}

