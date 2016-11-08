using UnityEngine;
using System.Collections;

public class MoneyPickup : MonoBehaviour {

    public Player_Score score;
    bool touchsmall;
    bool touchmedium;
    bool touchhigh;


	void Start ()
    {
        score = score.GetComponent<Player_Score>();
	}
	
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Space) && touchsmall)
        {
            print(":)");
        }
	}

    void OnCollisionStay2D(Collision2D other)
    {
        while(other.gameObject.tag == "small")
        {
            touchsmall = true;
        }
        while (other.gameObject.tag == "medium")
        {
            touchmedium = true;
        }
        while (other.gameObject.tag == "high")
        {
            touchhigh = true;
        }
    }
}
