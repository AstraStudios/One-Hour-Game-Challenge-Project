using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyController : MonoBehaviour
{
    //Setnewdestination and LookingForTargets are borrowed from another game i made "2D Ai War Game"
    public int enemyHealth = 15;

    private float range = 1f;
    int moveSpeed = 5;

    float movementRange = 10f;
    float maxDistance = 30f;

    Vector2 wayPoint;

    // Start is called before the first frame update
    void Start()
    {
        SetNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
        AttackEnemy();
        LookingForTargets();
    }

    void AttackEnemy()
    {
        Collider2D[] colliderArray = Physics2D.OverlapCircleAll(transform.position, range);
        foreach (Collider2D collider2D in colliderArray)
        {
            if (gameObject.tag == "Enemy")
            {
                if (collider2D.tag == "Farmer")
                {
                    Debug.Log("Hit a farmer");
                }
                if (collider2D.tag == "Wall") {
                    Debug.Log("Hit a wall");
                }
                if (collider2D.tag == "Player")
                {
                    Debug.Log(collider2D.name + " got hit! He was hit by " + gameObject.name);
                    var player = GameObject.Find(collider2D.name);
                    //var playerHealth = redTeamUser.GetComponent<HealthManager>();
                    //player.health -= 1;
                }
            }
        }
    }

    void SetNewDestination()
    {
        // Find waypoint to go to
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }

    void LookingForTargets()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < movementRange)
        {
            SetNewDestination();
        }
    }
}
