using UnityEngine;
using System.Collections;

public class SetHighscore : HighscoreData 
{
    Player_Score Score;
	void Start()
	{
        Score = GameObject.FindObjectOfType<Player_Score>();
	}

	public void SetScore ()
	{
		if (PlayerHighscore < Score.PlayerScore)
		{
            PlayerHighscore = Score.PlayerScore;
		}
	}
}
