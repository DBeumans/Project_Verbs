﻿using UnityEngine;
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
    public void SetPlayerScore(string ObjectTag)
    {
        switch(ObjectTag)
        {
		case "Object_small": 
				_player_score += 1;
                break;
            case "Object_medium": 
                _player_score += 2;
                break;
            case "Object_high": 
                _player_score += 3;
                break;
        }
    }
}
