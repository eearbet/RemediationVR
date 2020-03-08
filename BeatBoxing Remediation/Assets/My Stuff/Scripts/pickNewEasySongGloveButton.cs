using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pickNewEasySongGloveButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "leftGloveMeshCollider")
        {
            SceneManager.LoadScene("EasySongSelection");
        }
        else if (other.gameObject.name == "rightGloveMeshCollider")
        {
            SceneManager.LoadScene("EasySongSelection");
        }
    }
}
