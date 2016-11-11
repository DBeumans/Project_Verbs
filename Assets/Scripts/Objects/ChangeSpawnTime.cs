using UnityEngine;
using System.Collections;

public class ChangeSpawnTime : MonoBehaviour {

    Enemy_Spawner _enemy_spawner;
    Objects_Spawner _object_spawner;

    float _spawntime;

    void Start()
    {
        _enemy_spawner = GetComponent<Enemy_Spawner>();
        _object_spawner = GetComponent<Objects_Spawner>();

        StartCoroutine(ChangeSpawntime());
    }

    IEnumerator ChangeSpawntime()
    {
        while (true)
        {
            _spawntime = Random.Range(1f, 4f);
            _enemy_spawner.SpawnTime = _spawntime;
            _spawntime = Random.Range(1f, 4f);
            _object_spawner.SpawnTime = _spawntime;
            yield return new WaitForSeconds(1f);
        }
    }

}
