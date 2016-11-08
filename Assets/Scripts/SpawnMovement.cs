using UnityEngine;
using System.Collections;

public class SpawnMovement : MonoBehaviour {

    float timer = 2f;
    float boundTimer = 3f;
    float random = Random.Range(0,3);
    Vector3 place;
    public GameObject startPlace;


    void Start ()
    {
        place = new Vector3(7.5f, random, 0);
	}
	
    
	void Update ()
    {
        timer -= Time.deltaTime;
        boundTimer -= Time.deltaTime;
        if(timer < 0)
        {
            timer = 2;
            place = new Vector3(7.5f, random, 0);
            this.transform.position = place;
            boundTimer = 3f;
            random = Random.Range(0,3);
            Debug.Log(random);

        }
        if (boundTimer < 0)
        {
            this.transform.position = startPlace.transform.position;
        }
	}
}
