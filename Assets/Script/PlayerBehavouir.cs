using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavouir : MonoBehaviour {
    Game_manager gamManagerRef;
     float speed;
    Vector3 pos;
    float xMovement;
   




	// Use this for initialization
	void Start () {

       
        gamManagerRef = GameObject.FindGameObjectWithTag("Game_manager").GetComponent<Game_manager>();
        speed = 20 * Time.deltaTime;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
     
        Game_manager.Movement();
      
    }
}
