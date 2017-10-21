using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions_GolfBall : MonoBehaviour {

    public Transform spawnPoint;

    public GameManager gameManager;

    //The number of times the ball has been hit by
    private int timesHit = 0;

	// Use this for initialization
	void Start () {
        respawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            gameManager.victory();
        }
        else if (other.CompareTag("BallKiller"))
        {
            respawn();
        }

    }

    public void respawn()
    {
        transform.position = spawnPoint.position;
    }

    public void incrementTimesHit()
    {
        timesHit++;
    }
}
