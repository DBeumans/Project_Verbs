using UnityEngine;
using System.Collections;

public class Player_Score : MonoBehaviour {

    int player_score; // private variable, do not change this to public, use the other player score variable to use it in other scripts.

    // use PlayerScore to use it for other scripts , example UI, save scripts.
    public int PlayerScore // Read only.
    {
        get
        {
            return player_score;
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        string tag = "SpecialObject"; // Change this to the tag the player needs to find to  obtain score.
        if(other.gameObject.tag == tag )
        {
            player_score++;
        }
    }
}
