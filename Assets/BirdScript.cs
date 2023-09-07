using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float deadZone = -50;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "Bob Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)   
        {
            myRigidBody.velocity = Vector2.up * jumpStrength;

        }

        if (transform.position.y < deadZone)
        {
            birdIsAlive = false;
            logic.gameOver();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.gameOver();
    }
}
