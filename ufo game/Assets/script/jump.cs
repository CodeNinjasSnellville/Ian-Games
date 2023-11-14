using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody2D player;
	
	public float springforce = 5.0f;

	
	void Awake()
	{
		player.GetComponent<Rigidbody2D>();
	}
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetKeyDown("up"))
        {
            player.velocity = new Vector2(0.0f, 0.0f);
            player.AddForce(new Vector2(player.velocity.x, springforce));

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "flipg")
        {
            springforce = springforce * -1.0f;

            if (Input.GetKeyDown("space") || Input.GetKeyDown("up"))
            {
                player.velocity = new Vector2(0.0f, 0.0f);
                player.AddForce(new Vector2(player.velocity.x, -springforce));

            }
        }
    }
}
