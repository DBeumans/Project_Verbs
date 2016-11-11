using UnityEngine;
using System.Collections;

public class Enemy_GetDamage : MonoBehaviour {

    Enemy_Data _enemy_data;

    void Start()
    {
        _enemy_data = gameObject.GetComponent<Enemy_Data>();
    }

    public void GetDamage()
    {
        _enemy_data.EnemyHealth -= 1;
    }
}
