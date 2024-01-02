using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class die : MonoBehaviour
{
   public GameObject player;
   public GameObject tryagain;

	public Text gameOver;
    void Start()
    {
        gameOver.text = " ";
		tryagain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter2D(Collider2D other)
		{
			if(other.gameObject.tag == "enemy")
			{
				Destroy(player);
			Destroy(other);
			gameOver.text = "that has gotta hurt";
			tryagain.SetActive(true);
			Time.timeScale = 0.0f;
		}
			else if (other.gameObject.tag == "enemy2")
		{
			Destroy(player);
			Destroy(other);
			gameOver.text = "where did the laser even come from anyway?";
			tryagain.SetActive(true);
			Time.timeScale = 0.0f;
		}
			else if (other.gameObject.tag == "enemy3")
        {
			Destroy(player);
			Destroy(other);
			gameOver.text = "woah where could you be going?";
			tryagain.SetActive(true);
			Time.timeScale = 0.0f;
		}
		else if (other.gameObject.tag == "enemy4")
		{
			Destroy(player);
			Destroy(other);
			gameOver.text = "WHAT";
			tryagain.SetActive(true);
			Time.timeScale = 0.0f;
		}

	}
	
}
