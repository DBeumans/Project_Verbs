﻿using UnityEngine;
using System.Collections;

public class SpawningBehaviour : MonoBehaviour {

    public void ObjectSpawner(GameObject[] gameObject, Transform spawnPoints)
    {
        int SpawnObject = Random.Range(0, gameObject.Length);
        Instantiate(gameObject[SpawnObject], spawnPoints.position, spawnPoints.rotation);
    }
}
