using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    private Global_Settings global_Settings;
    public GameObject thisProjectile;

    public float fallSpeedSetting;
    public float forwardMotionEffect;

    public float myTimeFalling;

    void Awake()
    {
        global_Settings = GameObject.Find("Global").GetComponent<Global_Settings>();
        thisProjectile = this.gameObject;
    }

        void Start ()
    {
        fallSpeedSetting = global_Settings.projectileDropFactor;
        forwardMotionEffect = global_Settings.projectileForwardActor;
	}
    
    void Update()
    {
        float fallingEffect = fallSpeedSetting * Time.deltaTime;
        float forwardEffect = forwardMotionEffect * Time.deltaTime;

        Vector3 newProjectilePosition = new Vector3(forwardEffect, fallingEffect, 0f);

        thisProjectile.transform.position += newProjectilePosition;

        myTimeFalling += Time.deltaTime;

        if (this.gameObject.transform.position.y <= -10)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
            Destroy (this.gameObject);
    }
}
