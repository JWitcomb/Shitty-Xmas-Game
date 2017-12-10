using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    private Global_Settings global_Settings;

    public GameObject[] targets;
    private GameObject spawnLocator;
    private Vector3 spawnPosition;
    private GameObject chosenTarget;

    private float timeToNextSpawn;
    private float minSpawnTime;
    private float maxSpawnTime;
    private bool spawnAtStart;



    void Awake()
    {
        global_Settings = GameObject.Find("Global").GetComponent<Global_Settings>();
        spawnLocator = this.gameObject;
    }

    void Start ()
    {
        spawnPosition = spawnLocator.transform.position;

        minSpawnTime = global_Settings.minTimeBetweenTargetSpawn;
        maxSpawnTime = global_Settings.maxTimeBetweenTargetSpawn;
        spawnAtStart = global_Settings.spawnOnStart;

        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);

        if (spawnAtStart == true)
        {
            SpawnTarget();
        }
    }
	
	void Update ()
    {
        timeToNextSpawn -= Time.deltaTime;

        if (timeToNextSpawn <= 0)
        {
            SpawnTarget();
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    void SpawnTarget ()
    {
        int index = Random.Range(0, (targets.Length - 1));
        chosenTarget = Instantiate(targets[index], spawnPosition, Quaternion.identity) as GameObject;
    }
}
