using UnityEngine;
using System.Collections;

public class highscore : MonoBehaviour 
{
	int highScore;
	public Player_Score Score;

	void Start()
	{
		Score = GetComponent<Player_Score>();
	}

	public void HighScore ()
	{
		if (highScore < Score.PlayerScore)
		{
			highScore = Score.PlayerScore;
		}
	}
}