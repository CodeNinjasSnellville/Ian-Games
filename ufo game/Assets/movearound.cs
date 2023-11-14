using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movearound : MonoBehaviour
{
    public Rigidbody2D player;

    private float speed = 0.0f;
    private float maxspeed = 10.0f;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (speed < 0)
            {
                speed--;
            }
            speed--;
            player.velocity = new Vector2(speed, 0.0f);
        } else if (Input.GetKeyDown(KeyCode.RightArrow)){
            if(speed > 0)
            {
                speed++;
            }
            speed++;
            player.velocity = new Vector2(speed, 0.0f);
        }

        if(speed > maxspeed)
        {
            speed = maxspeed;
        }
    }
}
