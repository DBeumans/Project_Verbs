using UnityEngine;
using System.Collections;

public class Enemy_Damage : MonoBehaviour {

    int _enemy_damage;

    public int EnemyDamage { get { return _enemy_damage;  } }

    void Start()
    {
        _enemy_damage = Random.Range(0, 10);
    }
}
