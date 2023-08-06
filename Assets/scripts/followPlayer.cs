using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{

  
    bus b;
    
    // Start is called before the first frame update
    void Start()
    {
        b=GameObject.Find("van").GetComponent<bus>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
       
        transform.position = new Vector3(b.transform.position.x, 5.2f, b.transform.position.z); 
        transform.rotation = b.transform.rotation;

    }
}
