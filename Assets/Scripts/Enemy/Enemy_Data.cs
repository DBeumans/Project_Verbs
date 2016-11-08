using UnityEngine;
using System.Collections;

public class Enemy_Data : MonoBehaviour {

    // you were killed by < object name >
    // switch statement om tags binnen te halen en aan de hand daarvan een naam aan plakken dat je als text ziet.

    Enemy_DamageType _enemy_damageType;
    Enemy_NamesData _enemy_nameData;

    [SerializeField]
    string _enemy_name;
    string _enemy_damage;

    void Start()
    {

        _enemy_damageType = GetComponent<Enemy_DamageType>();
        _enemy_nameData = GetComponent<Enemy_NamesData>();

        if(_enemy_nameData.EnemyName != "")
        {
            _enemy_name = _enemy_nameData.EnemyName;
        }
        

        Debug.Log("Enemy Name: " +_enemy_name);
    }
    
}
