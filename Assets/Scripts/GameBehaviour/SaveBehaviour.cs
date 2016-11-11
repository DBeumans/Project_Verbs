using UnityEngine;
using System.Collections;

public class SaveBehaviour : MonoBehaviour {

    HighscoreData _highscore;
    Player_Score _PlayerScore;

    int _player_highscore, _player_score;

    void Start()
    {
        _highscore = GameObject.FindObjectOfType<HighscoreData>();
        _PlayerScore = GameObject.FindObjectOfType<Player_Score>();
    }
    
    public void SaveScore()
    {
        _player_highscore = _highscore.PlayerHighscore;
        _player_score = _PlayerScore.PlayerScore;

        PlayerPrefs.SetInt("Highscore", _player_highscore);
        PlayerPrefs.SetInt("Score", _player_score);

       // Debug.Log("Highscore: "+PlayerPrefs.GetInt("Highscore"));
    }
}
