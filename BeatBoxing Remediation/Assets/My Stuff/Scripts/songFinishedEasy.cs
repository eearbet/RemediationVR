using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishSong : MonoBehaviour
{
    private float timePassed = 0;
    private AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        // if more than 20 seconds have passed, this is used to make sure I don't do it before the song
        // starts from my delayed start
        if (timePassed > 20)
        {
            if (!myAudioSource.isPlaying)
            {
                // this needs to send you to the scoreboard scene once I make it
                SceneManager.LoadScene("EasySongSelection");
            }
        }
    }
}
