using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {


    public float moveSpeed;


    private Rigidbody2D rb;

    public float playerHealth;

    public GameObject attackObject;

    public GameObject deathScreen;

    public GameObject heartOne;
    public GameObject heartTwo;
    public GameObject heartThree;



    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        deathScreen.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            rb.velocity = new Vector2(moveSpeed, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
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

        if(playerHealth == 2)
        {
            heartOne.SetActive(false);
        }

        if (playerHealth == 1)
        {
            heartTwo.SetActive(false);
        }


        if (playerHealth <= 0)
        {
            heartThree.SetActive(false);
            Debug.Log("You Died!");
            deathScreen.SetActive(true);
        }
    }

}

