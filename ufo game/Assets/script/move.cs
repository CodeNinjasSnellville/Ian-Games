using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	private Rigidbody2D bject;

	
	public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Time.deltaTime * -speed ,0,0);
		
		
    }
}
   