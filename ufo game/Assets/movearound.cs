using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movearound : MonoBehaviour
{
    public Rigidbody2D player;
    private Rigidbody2D obstacl;

    private float speed = 0.0f;
    private float maxspeed = 7.5f;

    private float rate = 0.1f;

    // Update is called once per frame
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (speed < 0)
            {
                speed--;
            }
            speed--;
            player.velocity = new Vector2(speed, player.velocity.y);

        } else if (Input.GetKeyDown(KeyCode.RightArrow)){
            if(speed > 0)
            {
                speed++;
            }
            speed++;
            player.velocity = new Vector2(speed, player.velocity.y);
        }

        if(speed > maxspeed)
        {
            speed = maxspeed;
        } else if (speed < -maxspeed)
        {
            speed = -maxspeed;
        }
    }
    void OnCollisionEnter2D(Collider2D obstacle)
    {

        GetComponent<Collider2D>().attachedRigidbody.velocity = player.velocity * -1;
    }

}
