using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text score;

    [Header("Target Settings")]
    public static int myScore;

    void Update()
    {
        score.text = "Score: " + myScore;
    }

}
