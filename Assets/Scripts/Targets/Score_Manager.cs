using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour {


    private Global_Settings global_Settings;

    public bool isFriendly;
    //public bool isChimney;

    private bool isClaimed = false;

    public int goodTargetPresentsHitValue;
    public int goodTargetBombHitValue;
    public int badTargetPresentsHitValue;
    public int badTargetBombHitValue;

    void Awake()
    {
        global_Settings = GameObject.Find("Global").GetComponent<Global_Settings>();
    }

    // Use this for initialization
    void Start ()
    {
        goodTargetBombHitValue = global_Settings.goodTargetBombHit;
        goodTargetPresentsHitValue = global_Settings.goodTargetPresentsHit;

        badTargetBombHitValue = global_Settings.badTargetBombHit;
        badTargetPresentsHitValue = global_Settings.badTargetPresentsHit;
	}
	


    void OnCollisionEnter2D(Collision2D other)
    {

        if (isClaimed == false)
        {
            if (other.gameObject.tag == "Present" && isFriendly == true)
            {
                Score.myScore += goodTargetPresentsHitValue;
                isClaimed = true;
            }
            else if (other.gameObject.tag == "Present" && isFriendly == false)
            {
                Score.myScore += badTargetPresentsHitValue;
                isClaimed = true;
            }
            else if (other.gameObject.tag == "Bomb" && isFriendly == true)
            {
                Score.myScore += goodTargetBombHitValue;
                isClaimed = true;
            }
            else if (other.gameObject.tag == "Bomb" && isFriendly == false)
            {
                Score.myScore += badTargetBombHitValue;
                isClaimed = true;
            }

        }




    }


}
