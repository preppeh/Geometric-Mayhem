using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGetsHit : MonoBehaviour
{

    private int health;

    void Start() 
    {
        health = 3;
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag.Equals("Projectile")) 
        {
            Destroy(col.gameObject);
            health -= 1;
        }
    }

    void Update() 
    {
        if (health == 0) 
        {
            Status.playerScore += 5;
            Destroy(gameObject);
        }
    }

}
