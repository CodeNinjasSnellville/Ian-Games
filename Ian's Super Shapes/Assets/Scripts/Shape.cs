using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{   //Rigidbody for object
    [Header("Rigidbody Object")]
    public Rigidbody2D rb;
    //Shrinking speed
    [Header("Default Shrinking Speed")]
    public float shrinkSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //Rotation of the rigidbody
        //at a random range
        rb.rotation = Random.Range(of, 360f);
        //Local scale for the hexagon
        //equals one for all axes times
        //ten
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
