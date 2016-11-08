using UnityEngine;
using System.Collections;


public class Enemy_NamesData : MonoBehaviour {

    string ThisEnemyTag;

    string _enemy_name;
    public string EnemyName { get { return _enemy_name; } }

    void Start()
    {
        ThisEnemyTag = gameObject.tag;
        Debug.Log("This Enemy Tag: " + ThisEnemyTag);
        GetName();
    }

    void GetName()
    {
        switch (ThisEnemyTag)
        {
            case "Enemy_Stone":
                _enemy_name = "A Stone";
                Debug.Log(_enemy_name);
                break;
            case "Enemy_Spikes":
                _enemy_name = "Spikes";
                Debug.Log(_enemy_name);
                break;
            case "Enemy_Female":
                _enemy_name = "A Crazy Fan Girl";
                Debug.Log(_enemy_name);
                break;
            case "Enemy_Wallet":
                _enemy_name = "Female";
                Debug.Log(_enemy_name);
                break;
            default:
                _enemy_name = "NOT DEFINED";
                Debug.Log(_enemy_name);
                break;
        }
    }

}
