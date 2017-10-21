using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool changeScenesOnVictory;

    public AudioSource victoryAudioSource;

    public Interactions_GolfBall golfBall;

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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void respawnBall()
    {

    }
}
