using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Settings : MonoBehaviour {

    [Header("Player Settings")]
    public float sleighSlowDownFactor;
    public float sleighAccelerationSpeed;

    [Space(10)]

    [Header("Global Projectile Settings")]
    public float projectileDropFactor;
    public float projectileForwardActor;
    public float reloadTimeBetweenShots;

    [Space(10)]

    [Header("Field Of Play Settings")]
    public float minimumXClampSetting;
    public float maximumXClampSetting;
    public float minimumYClampSetting;
    public float maximumYClampSetting;

    [Space(10)]

    [Header("Target Settings")]
    public float targetMoveSpeed;

    [Space(10)]

    [Header("Spawn Settings")]
    [Range(1f, 10f)]
    public float minTimeBetweenTargetSpawn;
    [Range(1f,10f)]
    public float maxTimeBetweenTargetSpawn;
    public bool spawnOnStart;

    [Space(10)]
    [Header("Score Settings")]
    public float goodTargetPresentsHit;
    public float goodTargetBombHit;
    public float badTargetPresentsHit;
    public float badTargetBombHit;

    [Space(10)]
    public float dropDistanceScoreMultiplier;


}
