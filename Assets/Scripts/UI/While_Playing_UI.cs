﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class While_Playing_UI : MonoBehaviour {

    [SerializeField]
    Text _player_scoreText;
    int _playerScore;

    [SerializeField]
    Text _player_healthText;
    int _playerHealth;

    Player_Score _Player_Score;
    Player_HealthData _Player_Health;

    void Start()
    {
        _Player_Score = GameObject.FindObjectOfType<Player_Score>();
        _Player_Health = GameObject.FindObjectOfType<Player_HealthData>();
    }

    void Update()
    {
        _playerScore = _Player_Score.PlayerScore;
        _playerHealth = _Player_Health.PlayerHealth;
        ShowText();
    }

    void ShowText()
    {
        _player_scoreText.text = "Score: " + "$" + _playerScore;
        _player_healthText.text = "Health: " + _playerHealth + " %";
    }
}
