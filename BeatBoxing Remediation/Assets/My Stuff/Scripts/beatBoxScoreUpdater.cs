using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beatBoxScoreUpdater : MonoBehaviour
{
   // public static int leftScoreHit = 0;
   // public static int leftScoreTotal = 0;
   // public static Text LeftScore;

    public static int rightScoreHit = 0;
    public static int rightScoreTotal = 0;
    public static Text RightScore;
    void Start()
    {
    //    LeftScore = GetComponent<Text>();
        RightScore = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
    //    LeftScore.text = leftScoreHit.ToString() + " / " + leftScoreTotal.ToString();

        RightScore.text = rightScoreHit.ToString() + " / " + rightScoreTotal.ToString();
    }
}
