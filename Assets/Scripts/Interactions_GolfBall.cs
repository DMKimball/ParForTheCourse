using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions_GolfBall : MonoBehaviour {

    public GameManager gm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Goal"))
        {
            gm.victory();
        }
    }
}
