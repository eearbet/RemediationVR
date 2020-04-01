using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class beatBoxRightScoreFinal : MonoBehaviour
{

    public static TextMeshPro rightPunchScoreFinal;

    // Start is called before the first frame update
    void Start()
    {
        rightPunchScoreFinal = GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        rightPunchScoreFinal.text = beatBoxScoreUpdater.RightScore.text;
        rightPunchScoreFinal.SetText(beatBoxScoreUpdater.RightScore.text);
    }
}
