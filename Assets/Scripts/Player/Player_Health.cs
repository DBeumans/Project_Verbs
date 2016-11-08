using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour {

    int _player_health;

    public int PlayerHealth
    {
        get
        {
            return _player_health;
        }
    }

    void Start()
    {
        _player_health = 100;
    }

    void Update()
    {
        if(_player_health <= 0)
        {
            // player is dead.
            // do logic.
        }
    }

    public void SetPlayerDamage(string TypeOfEnemy)
    {
        switch(TypeOfEnemy)
        {
            case "Enemy_Spikes": // needs to change to Enemy_<what the object is> example: Enemy_Spikes.
                _player_health -= 10;
                break;

            case "Enemy_Stone": // needs to change to Enemy_<what the object is> example: Enemy_Spikes.
                _player_health -= 15;
                break;
            case "Enemy_Wallet":
                _player_health -= 10;
                break;

            case "Enemy_Rocket": // needs to change to Enemy_<what the object is> example: Enemy_Spikes.
                _player_health -= 20;
                break;

            case "Death_Trigger": // when it touches the death trigger.
                _player_health -= 100;
                break;
        }
    }
}
