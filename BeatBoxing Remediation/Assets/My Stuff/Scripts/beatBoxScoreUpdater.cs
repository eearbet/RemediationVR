using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beatBoxScoreUpdater : MonoBehaviour
{
    public static int leftScoreHit = 0;
    public static int leftScoreTotal = 0;
    public Text leftEndScoreFraction;

    public static int rightScoreHit = 0;
    public static int rightScoreTotal = 0;
    public Text rightEndScoreFraction;

    // Update is called once per frame
    void Update()
    {
        leftEndScoreFraction.text = leftScoreHit.ToString() + " / " + leftScoreTotal.ToString();

        rightEndScoreFraction.text = rightScoreHit.ToString() + " / " + rightScoreTotal.ToString();
    }
}
