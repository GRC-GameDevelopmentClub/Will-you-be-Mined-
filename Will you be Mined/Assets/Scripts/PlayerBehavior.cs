using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {


    public float moveSpeed;


    private Rigidbody2D rb;

    public float playerHealth;

    public GameObject attackObject;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            attackObject.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            attackObject.SetActive(false);
        }


        

        if(playerHealth <= 0)
        {
            Debug.Log("You Died!");
        }
    }

}

