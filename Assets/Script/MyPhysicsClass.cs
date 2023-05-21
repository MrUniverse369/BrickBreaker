using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPhysicsClass : MonoBehaviour {
    
    public static float mass;
    public static float gravity;
    public static float speed;
    public static Vector2 velocity;
    public static Vector2 pos;
    public static Transform ballTransRef;
   Rigidbody2D rb;
    float collisionSpeed;





    // Use this for initialization
    void Start ()
    {
        collisionSpeed = 1 * Time.deltaTime;
        rb = gameObject.GetComponent<Rigidbody2D>();

        ballTransRef = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Leftwall")
        {
            rb.AddForce(Vector2.right*collisionSpeed);
        }
        if (collision.gameObject.tag == "Rightwall")
        {
            rb.AddForce(Vector2.left*collisionSpeed);
        }
        if (collision.gameObject.tag == "Topwall")
        {
            rb.AddForce(Vector2.right*collisionSpeed);
        }

    }



}
