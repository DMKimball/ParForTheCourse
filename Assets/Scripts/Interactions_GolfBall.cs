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

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Goal"))
        {
            gameManager.victory();
        } else if (collision.collider.CompareTag("BallKiller"))
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
