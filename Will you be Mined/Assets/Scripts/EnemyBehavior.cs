using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;

    private Rigidbody2D rb;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    private bool notAtEdge;
    public Transform edgeCheck;

    public float enemyHealth;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

        if (hittingWall || !notAtEdge)
        {
            moveRight = !moveRight;
        }

        if (moveRight)
        {
            transform.localScale = new Vector3(-4.5f, 4.5f, 4.5f);
            rb.velocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            transform.localScale = new Vector3(4.5f, 4.5f, 4.5f);
            rb.velocity = new Vector2(-moveSpeed, 0);
        }

        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }

	}

   
}
