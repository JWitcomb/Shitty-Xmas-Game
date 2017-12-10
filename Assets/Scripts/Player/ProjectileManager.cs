using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour {

    private Global_Settings global_Settings;

    public GameObject[] projectileList;
    private int arrayPosition = 0;
    public GameObject thisGameObject;
    private Vector3 spawnPosition;
    private GameObject currentlySelectedPayload;
    private GameObject payload;

    public float reloadTime;
    private bool shotFired = false;

    private float currentTimer;

    void Awake()
    {
        global_Settings = GameObject.Find("Global").GetComponent<Global_Settings>();
        //thisGameObject = this.gameObject;
    }

    // Use this for initialization
    void Start ()
    {
        reloadTime = global_Settings.reloadTimeBetweenShots;
        currentlySelectedPayload = projectileList[0];
        currentTimer = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Current Selected Item: " + projectileList[arrayPosition]);
        //Debug.Log(shotFired);
        spawnLocation();
        DropProjectile();
        PayloadManager();
        ReloadTimer();
	}

    // Counts the time between shos been fired, and resets the ability to drop a payload when the timer has don it's thing.
    void ReloadTimer ()
    {
        if (shotFired)
        {
            currentTimer -= Time.deltaTime;

            if (currentTimer <= 0)
            {
                shotFired = false;
                currentTimer = reloadTime;
            }
        }
    }

    // Updates the Vector3 value of the position where the projectiles will be dropped from.
    void spawnLocation()
    {
        spawnPosition = thisGameObject.transform.position;
    }

    // Basic inventory system to manage the currently selected payload type.
    void PayloadManager()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (arrayPosition >= projectileList.Length - 1)
            {
                arrayPosition = 0;
            }
            else
            {
                arrayPosition += 1;
            }
        }
    }

    // Drops the selected projectile when the button press is made.
    void DropProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space) && shotFired == false)
        {
            payload = Instantiate(projectileList[arrayPosition], spawnPosition, Quaternion.identity) as GameObject;
            shotFired = true;
        }
    }





}
