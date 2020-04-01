using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueBlockMove : MonoBehaviour
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
            Debug.Log("blue block made it past!");
            //beatBoxScoreUpdater.leftScoreTotal++;
            leftScoreUpdater.leftScoreTotal++;

            Destroy(this.gameObject);
        }
        else if (collision.gameObject.name == "leftGloveMeshCollider")
        {
           // beatBoxScoreUpdater.leftScoreHit++;
          //  beatBoxScoreUpdater.leftScoreTotal++;
            leftScoreUpdater.leftScoreHit++;
            leftScoreUpdater.leftScoreTotal++;
            Debug.Log("blue block destroied");
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.name == "rightGloveMeshCollider")
        {
            //beatBoxScoreUpdater.leftScoreTotal++;
            leftScoreUpdater.leftScoreTotal++;

            Debug.Log("Wrong Hand!");
            Destroy(this.gameObject);
        }
    }
}
    