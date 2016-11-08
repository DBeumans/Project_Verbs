using UnityEngine;
using System.Collections;

public class Player_TriggerCollision : MonoBehaviour {


    Player_Score _player_score;
    Player_Damage _player_damage;

    void Start()
    {
        _player_score = GameObject.FindObjectOfType<Player_Score>();
        _player_damage = GameObject.FindObjectOfType<Player_Damage>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Player Health Check

        if (other.gameObject.tag.Contains("Enemy_") || other.gameObject.tag == "Death_Trigger")
        {
            _player_damage.SetPlayerDamage(other.gameObject.tag);
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
