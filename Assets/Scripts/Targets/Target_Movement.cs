using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Movement : MonoBehaviour {

    private Global_Settings global_Settings;

    private float localTargetMoveSpeed;
    private GameObject thisTarget;
    private Vector3 newTargetPosition;

  
    void Awake()
    {
        global_Settings = GameObject.Find("Global").GetComponent<Global_Settings>();
        thisTarget = this.gameObject;
    }

    void Start ()
    {
        localTargetMoveSpeed = global_Settings.targetMoveSpeed;
    }

	void Update ()
    {
        Movement();
        positionCheck();
	}

    void Movement ()
    {
        float thisTargeMovement = localTargetMoveSpeed * Time.deltaTime;

        Vector3 newTargetPosition = new Vector3(thisTargeMovement, 0f, 0f);

        thisTarget.transform.position += newTargetPosition;
    }

    void positionCheck()
    {
        if (thisTarget.transform.position.x <= -14)
        {
            Destroy(gameObject);
        }
    }
}
