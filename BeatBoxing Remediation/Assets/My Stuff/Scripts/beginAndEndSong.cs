using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beginAndEndSong : MonoBehaviour
{

    public float Z_Pos_CubeSpawner = 0;
    private float startTime = 0;
    private bool turnedOnPreviously = false;
    private float timePassed = 0;
    private AudioSource myAudioSource;
    private float songLength;


    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        startTime = Math.Abs(Z_Pos_CubeSpawner) / 2;
        songLength = myAudioSource.clip.length;
        musicCubeSpawner.timeToStopMakingBlocks = songLength - startTime;

    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > startTime)
        {
            if (turnedOnPreviously == false)
            {
                if (!myAudioSource.isPlaying)
                {
                    turnedOnPreviously = true;
                    myAudioSource.Play();
                }
            }
            else if (turnedOnPreviously == true)
            {
                // was playing already but now isn't anymore
                if (!myAudioSource.isPlaying)
                {
                    // this means end of song so go to scoreboard
                    // this needs to send you to the scoreboard scene once I make it
                    SceneManager.LoadScene("beatBoxEasySongSelection");
                }
            }
        }





    }
}
