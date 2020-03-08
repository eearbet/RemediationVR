using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class restartSongGloveButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if ( (other.gameObject.name == "leftGloveMeshCollider") || (other.gameObject.name == "rightGloveMeshCollider"))
        {
            beatBoxScoreUpdater.leftScoreHit = 0;
            beatBoxScoreUpdater.leftScoreTotal = 0;
            beatBoxScoreUpdater.rightScoreHit = 0;
            beatBoxScoreUpdater.rightScoreTotal = 0;

            SceneManager.LoadScene(sceneName);
        }
    }
}
