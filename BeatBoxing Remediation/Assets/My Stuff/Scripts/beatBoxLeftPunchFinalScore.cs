using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class beatBoxLeftPunchFinalScore : MonoBehaviour
{
    public static TextMeshPro leftPunchScoreFinal;

    void Start()
    {
        leftPunchScoreFinal = GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        leftPunchScoreFinal.text = leftScoreUpdater.LeftScore.text;
        leftPunchScoreFinal.SetText(leftScoreUpdater.LeftScore.text);
    }
}
