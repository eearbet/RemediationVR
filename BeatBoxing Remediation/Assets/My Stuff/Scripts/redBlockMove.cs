using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBlockMove : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "backWallCounter") || (collision.gameObject.name == "PodiumItself"))
        {
            Debug.Log("red block made it past!");
            beatBoxScoreUpdater.rightScoreTotal++;
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.name == "rightGloveMeshCollider")
        {
            beatBoxScoreUpdater.rightScoreHit++;
            beatBoxScoreUpdater.rightScoreTotal++;
            Debug.Log("red block destroied");
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.name == "leftGloveMeshCollider")
        {
            beatBoxScoreUpdater.rightScoreTotal++;
            Debug.Log("Wrong Hand!");
            Destroy(this.gameObject);
        }
    }
}
