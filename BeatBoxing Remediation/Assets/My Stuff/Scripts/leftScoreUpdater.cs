using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leftScoreUpdater : MonoBehaviour
{

    public static int leftScoreHit = 0;
    public static int leftScoreTotal = 0;
    public static Text LeftScore;

    // Start is called before the first frame update
    void Start()
    {
        LeftScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        LeftScore.text = leftScoreHit.ToString() + " / " + leftScoreTotal.ToString();
        beatBoxLeftPunchFinalScore.leftPunchScoreFinal.text = LeftScore.text;
    }
}
