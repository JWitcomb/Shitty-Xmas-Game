using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Neon_Sign : MonoBehaviour {

    public int restTime = 1;
    private float timer;
    private bool isLit = true;

    private MeshRenderer sign;



	// Use this for initialization
	void Start ()
    {
        timer = 0;
        sign = this.gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        timer += Time.deltaTime;

	    if (isLit)
        {
            sign.enabled = true;

            if (timer >= restTime)
            {
                isLit = false;
                timer = 0;
            }
        }	
        else
        {
            sign.enabled = false;

            if (timer >= restTime)
            {
                isLit = true;
                timer = 0;
            }
        }
	}
}
