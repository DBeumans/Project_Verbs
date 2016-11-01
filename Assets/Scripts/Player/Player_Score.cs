using UnityEngine;
using System.Collections;

public class Player_Score : MonoBehaviour {

    int _player_score; // private variable, do not change this to public, use the other player score variable to use it in other scripts.

    // use PlayerScore to use it for other scripts , example UI, save scripts.
    public int PlayerScore // Read only.
    {
        get
        {
            return _player_score;
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        
        if(other.gameObject.tag.Contains("Object_")) // checks if the other.gameobject.tag have Object_ .
        {
            SetPlayerScore(other.gameObject.tag);
        }
    }

    void SetPlayerScore(string ObjectTag)
    {
        switch(ObjectTag)
        {
            case "Object_Yellow": // needs to change to Object_<what the object is> example: Object_Wallet.
                _player_score += 1;
                break;
            case "Object_Red": // needs to change to Object_<what the object is> example: Object_Wallet.
                _player_score += 2;
                break;
            case "Object_Blue": // needs to change to Object_<what the object is> example: Object_Wallet.
                _player_score += 3;
                break;
        }
    }
}
