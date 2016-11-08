using UnityEngine;
using System.Collections;

public class Player_HealthData : MonoBehaviour {

    Player_HealthRegeneration _PlayerHealthGeneration;
    Player_Death _player_Death;

    int _player_currentHealth;
    int _player_maxHealth = 100;
    public int PlayerHealth
    {
        get
        {
            return _player_currentHealth;
        }
        set
        {
            _player_currentHealth = value;
        }
    }

    void Start()
    {
        _player_currentHealth = _player_maxHealth;
        _PlayerHealthGeneration = gameObject.GetComponent<Player_HealthRegeneration>();
        _player_Death = GameObject.FindObjectOfType<Player_Death>();

        StartCoroutine("HealthCheck");
    }

    IEnumerator HealthCheck()
    {
        while(_player_currentHealth > 0 && _player_currentHealth < 101)
        {
            if (PlayerHealth != 100 && !_PlayerHealthGeneration.IsGeneratingHealth)
            {
                _PlayerHealthGeneration.StartHealthGeneration();
            }
            //alive
            yield return new WaitForSeconds(.5f);
        }
        //dead  
        _player_Death.PlayerDeath();

    }
}
