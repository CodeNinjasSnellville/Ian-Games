using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{ //If an object collides with a trigger
    private void onTriggerEnter2D(Collider2D collision)
    
    {
        //Add score
        Score.score++;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
