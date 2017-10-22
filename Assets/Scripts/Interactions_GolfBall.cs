using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions_GolfBall : MonoBehaviour
{

    public Transform spawnPoint;

    public GameManager gameManager;

    public InputManager inputManager;

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
            inputManager.Vibrate();
        }
    }
    public void Respawn()
    {
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
