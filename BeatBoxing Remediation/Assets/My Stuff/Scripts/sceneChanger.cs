using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    //levelLoader scene = new levelLoader();
    public Animator transition;

    public void changeSceneTo(string sceneToChangeTo)
    {
        //transition.SetTrigger("Start");
        SceneManager.LoadScene(sceneToChangeTo);

        //scene.LoadNextScene(sceneToChangeTo);
    }
}
