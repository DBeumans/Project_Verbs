using UnityEngine;
using System.Collections;

public class HighscoreData : MonoBehaviour {

    int highScore;

    public int PlayerHighscore { get { return highScore; } set { highScore = value; } }

    void Awake()
    {
        LoadScore();
    }

    void LoadScore()
    {
        //Debug.Log("Highscore: " + PlayerHighscore);
        PlayerHighscore = PlayerPrefs.GetInt("Highscore");
    }
}
