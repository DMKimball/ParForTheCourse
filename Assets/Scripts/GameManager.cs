using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource victoryAudioSource;

    public Interactions_GolfBall[] golfBalls;

    public GameObject[] putters;

    public int startingPutterIndex;

    private int currentPutterIndex;

    private int currRoundIndex;

    //The number of times the ball has been hit by
    private int numTimesBallHit = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Victory()
    {
        Debug.Log("User won Course");
        victoryAudioSource.Play();
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
