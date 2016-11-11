using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Show_Scores : MonoBehaviour {

    [SerializeField]
    Text _player_ScoreText;
    [SerializeField]
    Text _player_HighscoreText;

    void Start()
    {
        ShowScore();
    }

    void ShowScore()
    {
        _player_HighscoreText.text = "Highscore: " + "$"+PlayerPrefs.GetInt("Highscore");
        _player_ScoreText.text = "Score: " + "$" + PlayerPrefs.GetInt("Score");
    }
    
}
