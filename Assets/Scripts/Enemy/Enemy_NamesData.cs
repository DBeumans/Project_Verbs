using UnityEngine;
using System.Collections;


public class Enemy_NamesData : MonoBehaviour {

    /*
        Use Enemy_Data Class to get enemy name.
    */

    string ThisEnemyTag;

    string _enemy_name;
    public string EnemyName { get { return _enemy_name; } }

    void Start()
    {
        ThisEnemyTag = gameObject.tag;
        GetName();
    }

    void GetName()
    {
        switch (ThisEnemyTag)
        {
            case "Enemy_Stone":
                _enemy_name = "A Stone";
                break;
            case "Enemy_Spikes":
                _enemy_name = "Spikes";
                break;
            case "Enemy_Female":
                _enemy_name = "A Crazy Fan Girl";
                break;
            case "Enemy_Wallet":
                _enemy_name = "Female";
                break;
            default:
                _enemy_name = "NOT DEFINED";
                break;
        }
    }

}
