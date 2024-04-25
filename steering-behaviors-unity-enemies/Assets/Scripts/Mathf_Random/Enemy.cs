using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public Transform player;

    [HideInInspector]
    public float enemySpeed = 0f;

    [HideInInspector]
    public float killDistance = 0f;

    void Start()
    {
        float playerDistance = Vector2.Distance(player.position, transform.position);
        Debug.LogFormat("I am a new enemy ({0}). Distance to player:: {1}", name, playerDistance);
    }

    // Approach the player and if they are within a given distance, "kill" them
    private void Update()
    {
        if (player == null) 
            return;

        Vector3 playerVector = player.position - transform.position;

        // A-Option 1: Move by hand
        Vector3 speedDirection = playerVector.normalized;
        transform.position += speedDirection * enemySpeed * Time.deltaTime;

        // A-Option 2: MoveTowards
        //transform.position = Vector3.MoveTowards(transform.position, player.position, enemySpeed * Time.deltaTime);

        
        // B-Option 1: sqrMagnitude
        if (playerVector.sqrMagnitude < (killDistance * killDistance))
        // B-Option 2: Vector3.Distance
        //if (Vector3.Distance(transform.position, player.position) < killDistance)
        {
            Debug.Log("I caught up with the enemy :)");
            Destroy(player.gameObject);
        }
    }
}
