using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject block;
	public GameObject block2;
	public GameObject block3;

  public Transform clock;
public Vector3 cmon;

    void Start()
    {
		Time.timeScale = 1.0f; 
     Invoke("Spawnenemy",Random.Range(0.45f,3.0f));
	 
	  Invoke("spawnplatform",Random.Range(0.45f,3.0f));
	
	Invoke("spawnswitcharoo",Random.Range(2.5f,3.0f));
    }
void Spawnenemy()
{
	  Invoke("Spawn",Random.Range(0.45f,3.0f));
}
void spawnplatform()
{
	  Invoke("Spawn2",Random.Range(1.55f,4.5f));
}
void spawnswitcharoo()
{
	  Invoke("Spawn3",Random.Range(1.55f,4.5f));
}
    // Update is called once per frame
    void Update()
    {
        var position = new Vector3(40.0f,Random.Range(10.0f,-10.0f),0);
	    var position2 = new Vector3(-40.0f,0 ,0);
        
    }
	
	public void Spawn()
	{
	  Instantiate(block, new Vector3(40.0f,Random.Range(10.0f,-10.0f),0), Quaternion.identity);
	   Invoke("Spawnenemy",Random.Range(0.45f,3.0f));
	}
	
		public void Spawn2()
	{
	  Instantiate(block2, new Vector3(40.0f,Random.Range(10.0f,-10.0f),0), Quaternion.identity);
	   Invoke("spawnplatform",Random.Range(1.45f,5.0f));
	 }
	
			public void Spawn3()
	{
	  Instantiate(block3, new Vector3(40.0f,Random.Range(10.0f,-10.0f),0), Quaternion.identity);
	   Invoke("spawnplatform",Random.Range(2.45f,5.0f));
	 }

}
