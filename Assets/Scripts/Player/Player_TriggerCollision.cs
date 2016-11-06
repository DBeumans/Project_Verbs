using UnityEngine;
using System.Collections;

public class Player_TriggerCollision : MonoBehaviour {


    Player_Score _player_score;
    Player_Health _player_health;

    void Start()
    {
        _player_score = GameObject.FindObjectOfType<Player_Score>();
        _player_health = GameObject.FindObjectOfType<Player_Health>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Player Health Check

        if (other.gameObject.tag.Contains("Enemy_") || other.gameObject.tag == "Death_Trigger")
        {
            _player_health.SetPlayerDamage(other.gameObject.tag);
            Destroy(other.gameObject);
        }

        // Player Score Check

        if (other.gameObject.tag.Contains("Object_")) // checks if the other.gameobject.tag have Object_ .
        {
            _player_score.SetPlayerScore(other.gameObject.tag);
            Destroy(other.gameObject);
        }
    }
}
