using UnityEngine;
using System.Collections;

public class Objects_Spawner : SpawningBehaviour {

    //Object to spawn , its a array so you can spawn different objects of the same type.
    [SerializeField]
    GameObject[] Objects;
    //Spawnpoints, where the objects needs to spawn.
    [SerializeField]
    Transform spawnPoints;
    float spawnTime = 2f;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        ObjectSpawner(Objects, spawnPoints);
    }
}
