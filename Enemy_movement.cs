using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    public float moveSpeed = 1f;

    public Transform player;

    private Rigidbody2D rb;


    Vector2 movement;
    Vector2 moveDirection;
    float lookAngle;

    void Start() 
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = player.position - transform.position;
        lookAngle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg - 90f;
        movement = moveDirection.normalized;
    }

    void FixedUpdate() 
    {
        rb.rotation = lookAngle;
        rb.MovePosition((Vector2)transform.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }
}
