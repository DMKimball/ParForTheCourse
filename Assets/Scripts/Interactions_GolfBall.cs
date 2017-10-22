using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions_GolfBall : MonoBehaviour
{

    public Transform spawnPoint;

    public GameManager gameManager;

    public InputManager inputManager;

    public GameObject victoryText1, victoryText2;

    private Rigidbody rBody;

    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            if (victoryText1 != null) victoryText1.SetActive(true);
            if (victoryText2 != null) victoryText2.SetActive(true);
            gameManager.Victory();
            StartCoroutine(RespawnBallAfterDelay(2));
        }
        else if (other.CompareTag("BallKiller"))
        {
            Respawn();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Putter"))
        {
            print("Ball Hit!");
            gameManager.IncrementNumTimesBallHit();
            gameManager.HitSound();
            inputManager.Vibrate();
        }
    }
    private void Respawn()
    {
        Debug.Log("Spawned Ball");
        transform.position = spawnPoint.position;
        rBody.velocity = Vector3.zero;
    }

    public void SetSpawnPoint(Transform sp)
    {
        spawnPoint = sp;
    }

    IEnumerator RespawnBallAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);

        Respawn();
    }
}
