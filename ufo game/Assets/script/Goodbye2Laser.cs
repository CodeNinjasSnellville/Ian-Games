using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goodbye2Laser : MonoBehaviour
{
    
    
    // just in case, private GameObject Laser;

    void Start()
    {
    
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D notlaser)
    {
        if(notlaser.gameObject.tag == "destroyer")
        {
            print("Laser: ow," + notlaser.gameObject + " hurt me!!");
            Destroy(gameObject);
        }
    }
}
