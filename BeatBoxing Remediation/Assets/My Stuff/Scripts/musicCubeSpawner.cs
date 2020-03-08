using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicCubeSpawner : MonoBehaviour
{

    public GameObject[] cubeOptions;
    public Transform[] spawnPoints;
    public float sixtyOverBPM = 0;
    public string difficulty = "";
    private int currentBeat = 0;
    public int spawnOneOfEvery_X_Beats = 0;
    private float timer;
    private float totalTimer = 0;
    public static float timeToStopMakingBlocks;


    // Start is called before the first frame update
    void Start()
    {
        currentBeat = spawnOneOfEvery_X_Beats;
    }

    // Update is called once per frame
    void Update()
    {
        if ((timer > sixtyOverBPM) & (totalTimer < timeToStopMakingBlocks))
        {
            if (currentBeat == spawnOneOfEvery_X_Beats)
            {
                GameObject cube;

                // if easy keep left blocks blue and right blocks red and just left and right spawn points
                if (difficulty == "easy")
                {
                    if (0 == Random.Range(0,2))
                    {
                        cube = Instantiate(cubeOptions[0], spawnPoints[0]);
                    }
                    else
                    {
                        cube = Instantiate(cubeOptions[1], spawnPoints[1]);
                    }
                }
                // if medium or hard allow intermingling of them and allow 3 spawn points
                else
                {
                    // change this when I make it medium or hard
                    cube = Instantiate(cubeOptions[Random.Range(0, 2)], spawnPoints[Random.Range(0, 3)]);
                }
               
                cube.transform.localPosition = Vector3.zero;
                currentBeat = 0;
            }
            timer -= sixtyOverBPM;
            currentBeat++;
        }

        timer += Time.deltaTime;
        totalTimer += Time.deltaTime;
    }
}
