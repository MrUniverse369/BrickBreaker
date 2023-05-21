using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavoiur : MonoBehaviour {
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent < Rigidbody2D >();
	}
	void Movement()
    {
        rb.AddForce(new Vector2(0,-0.01f)*Time.deltaTime);
    }
	// Update is called once per frame
	void Update () {
        Movement();
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("HITTTTT");
            rb.AddForce(Vector2.up*2*Time.deltaTime);
            rb.AddTorque( 10*Time.deltaTime);
        }
        

    }




}
