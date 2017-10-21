using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool changeScenesOnVictory;

    public AudioSource victoryAudioSource;

    public Interactions_GolfBall golfBall;

    public GameObject[] putters;

    public int startingPutterIndex;

    private int currentPutterIndex;

    //The number of times the ball has been hit by
    private int numTimesBallHit = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void victory()
    {
        print("User won Round");
        victoryAudioSource.Play();
        if (changeScenesOnVictory)
        {
            StartCoroutine(ChangeScenesAfterDelay(3));
        }
    }

    public void RespawnBall()
    {
        golfBall.Respawn();
    }

    IEnumerator ChangeScenesAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SmallerPutter()
    {
        print("Switching to smaller putter!");
        if (currentPutterIndex - 1 >= 0)
        {

        }
    }

    public void LargerPutter()
    {
        print("Switching to larger putter!");
        if (currentPutterIndex + 1 < putters.Length)
        {

        }
    }

    public void IncrementNumTimesBallHit()
    {
        numTimesBallHit++;
    }

    public int GetNumTimesBallHit()
    {
        return numTimesBallHit;
    }
}
