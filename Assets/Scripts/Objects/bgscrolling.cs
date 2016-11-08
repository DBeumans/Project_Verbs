using UnityEngine;
using System.Collections;

public class bgscrolling : MonoBehaviour 
{
	
	public GameObject spawnBackground;

	void Update ()
	{
		if(this.transform.position.x < -10)
		{
			Vector2 spawnPosition = new Vector2 (10,0);
			Instantiate (spawnBackground, spawnPosition, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}