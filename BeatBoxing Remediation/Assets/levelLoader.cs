using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
    public Animator transition;
    public float tranistionTime = 1;



    public void LoadNextScene(string nameOfScene)
    {
        StartCoroutine(LoadScene(nameOfScene));
    }

    IEnumerator LoadScene(string nameOfScene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(tranistionTime);

        SceneManager.LoadScene(nameOfScene);
    }
}
