using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Global_Settings global_Settings;

    public GameObject Sleigh;
    public float sleighSlowDownEffectSetting;
    private Vector3 currentSleighPosition;
    public float sleighAccelerationSpeedSetting;

    // Clamps

    public float minimumXClamp;
    public float maximumXClamp;
    public float minimumYClamp;
    public float maximumYClamp;


    void Awake()
    {
        global_Settings = GameObject.Find("Global").GetComponent<Global_Settings>();
        Sleigh = this.gameObject;
    }


    void Start ()
    {
        sleighAccelerationSpeedSetting = global_Settings.sleighAccelerationSpeed;
        sleighSlowDownEffectSetting = global_Settings.sleighSlowDownFactor;

        minimumXClamp = global_Settings.minimumXClampSetting;
        maximumXClamp = global_Settings.maximumXClampSetting;
        minimumYClamp = global_Settings.minimumYClampSetting;
        maximumYClamp = global_Settings.maximumYClampSetting;
	}
	

	void Update ()
        
    {
            currentSleighPosition = new Vector3(Sleigh.transform.position.x - sleighSlowDownEffectSetting * Time.deltaTime, Sleigh.transform.position.y, 0f);

            Vector3 shipMovement = (new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f)) * sleighAccelerationSpeedSetting * Time.deltaTime;

            currentSleighPosition += shipMovement;

            currentSleighPosition.x = Mathf.Clamp(currentSleighPosition.x, minimumXClamp, maximumXClamp);
            currentSleighPosition.y = Mathf.Clamp(currentSleighPosition.y, minimumYClamp, maximumYClamp);

            Sleigh.transform.position = currentSleighPosition;
        
    }


}
