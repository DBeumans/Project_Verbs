using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum EnemyDamageType
{
    SmallDamage = 1,
    MediumDamage = 2,
    LargeDamage = 4,
    ExtraLargeDamage = 8,
    Lenght
}

public class Enemy_DamageType : MonoBehaviour {

    /*
        Use Enemy_Data Class to get the enemy damage.
    */

    int _damage;

    public int EnemyDamage { get { return _damage; } }

    void Start()
    {
        _damage = Random.Range(1, (int)EnemyDamageType.Lenght);
    }
}
