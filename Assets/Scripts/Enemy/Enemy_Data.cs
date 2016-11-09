using UnityEngine;
using System.Collections;

public class Enemy_Data : MonoBehaviour {

    // you were killed by < object name >
    // switch statement om tags binnen te halen en aan de hand daarvan een naam aan plakken dat je als text ziet.

    Enemy_DamageType _enemy_damageType;
    Enemy_NamesData _enemy_nameData;

    [SerializeField]
    string _enemy_name;
    int _enemy_damage;

    public string EnemyName { get { return _enemy_name; } }
    public int EnemyDamage { get { return _enemy_damage; } }

    void Start()
    {
        GetComponents();
        SetEnemyValues();
    }

    void GetComponents()
    {
        _enemy_damageType = GetComponent<Enemy_DamageType>();
        _enemy_nameData = GetComponent<Enemy_NamesData>();

    }

    void SetEnemyValues()
    {
        if (_enemy_nameData.EnemyName != null)
        {
            _enemy_name = _enemy_nameData.EnemyName;
        }

        if(_enemy_damageType.EnemyDamage != 0)
        {
            _enemy_damage = _enemy_damageType.EnemyDamage;
            Debug.Log("Enemy Damage: " + _enemy_damage);
        }
    }

}
