using UnityEngine;
using System.Collections;

public class SaveBehaviour : MonoBehaviour {

    HighscoreData _highscore;

    int _player_highscore;

    void Start()
    {
        _highscore = GameObject.FindObjectOfType<HighscoreData>();
    }
    
    public void SaveHighscore()
    {
        _player_highscore = _highscore.PlayerHighscore;

        PlayerPrefs.SetInt("Highscore", _player_highscore);

        Debug.Log("Highscore: "+PlayerPrefs.GetInt("Highscore"));
    }
}
