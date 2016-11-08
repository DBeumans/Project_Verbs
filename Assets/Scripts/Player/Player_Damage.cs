using UnityEngine;
using System.Collections;

public class Player_Damage : MonoBehaviour {

    Player_HealthData _PlayerHealth;

    void Start()
    {
        _PlayerHealth = GameObject.FindObjectOfType<Player_HealthData>();
    }

    public void SetPlayerDamage(string TypeOfEnemy)
    {
        switch (TypeOfEnemy)
        {
            case "Enemy_Spikes": // needs to change to Enemy_<what the object is> example: Enemy_Spikes.
                _PlayerHealth.PlayerHealth -= 10;
                break;

            case "Enemy_Stone": // needs to change to Enemy_<what the object is> example: Enemy_Spikes.
                _PlayerHealth.PlayerHealth -= 15;
                break;
            case "Enemy_Wallet":
                _PlayerHealth.PlayerHealth -= 100;
                break;

            case "Enemy_Rocket": // needs to change to Enemy_<what the object is> example: Enemy_Spikes.
                _PlayerHealth.PlayerHealth -= 20;
                break;

            case "Death_Trigger": // when it touches the death trigger.
                _PlayerHealth.PlayerHealth -= 100;
                break;
        }
    }

}
