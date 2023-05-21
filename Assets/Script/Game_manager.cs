using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_manager : MonoBehaviour {
    private Vector2[,] gameObjPos = new Vector2[6, 5];
    private Vector2 ClonePosData;
    private Rigidbody2D clone;
    public double health;
    public double score;
    public Rigidbody2D enemyRef;
    public Rigidbody2D playerSpawnObjRef;
    public Rigidbody2D ballRef;
    public Rigidbody2D topwallRef;
    public Rigidbody2D leftwallRef;
    public Rigidbody2D rightwallRef;
    public Rigidbody2D backGroundRef;
    public Rigidbody2D topWallClone;
    public Rigidbody2D backGroundClone;
    public static float xMovement;
    public static float xspeed;
    public static float speed;
    public static Vector3 velocity;
    public static Vector3 pos;
    public static Transform playerref;
    public static Transform ballTransRef;







    Quaternion rot;




    public  Game_manager()
    {

        
      
        this.health = 0;
        this.score = 0;

    }
    private void Awake()
    {
        
        gameObjPos[0, 0] = new Vector2(-4, 0);
        gameObjPos[0, 1] = new Vector2(-2, 0);
        gameObjPos[0, 2] = new Vector2(0, 0);
        gameObjPos[0, 3] = new Vector2(4, 0);
        gameObjPos[0, 4] = new Vector2(2, 0);
        

        gameObjPos[1, 0] = new Vector2(-4, 1);
        gameObjPos[1, 1] = new Vector2(-2, 1);
        gameObjPos[1, 2] = new Vector2(0, 1);
        gameObjPos[1, 3] = new Vector2(4, 1);
        gameObjPos[1, 4] = new Vector2(2, 1);
        


        gameObjPos[2, 0] = new Vector2(-4, 2);
        gameObjPos[2, 1] = new Vector2(-2, 2);
        gameObjPos[2, 2] = new Vector2(0, 2);
        gameObjPos[2, 3] = new Vector2(4, 2);
        gameObjPos[2, 4] = new Vector2(2, 2);

        gameObjPos[3, 0] = new Vector2(-4, 3);
        gameObjPos[3, 1] = new Vector2(-2, 3);
        gameObjPos[3, 2] = new Vector2(0, 3);
        gameObjPos[3, 3] = new Vector2(4, 3);
        gameObjPos[3, 4] = new Vector2(2, 3);


        gameObjPos[4, 0] = new Vector2(0, -3);
        gameObjPos[4, 1] = new Vector2(0, -1);
        gameObjPos[4, 2] = new Vector2(0, 3);


        gameObjPos[5, 0] = new Vector2(-5, -4.5f);
        gameObjPos[5, 1] = new Vector2(5, -4.5f);
        gameObjPos[5, 2] = new Vector2(-1.5f, 4);
        gameObjPos[5, 3] = new Vector2(-2.5f, -1);

       

        CreateLevel();
    }


    void Start()
    {
        
        playerref = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        ballTransRef = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();


    }

   /* void  messycodefixthislater()
    {
        int xPos = 0;
        int yPos = 0;
        Vector2 clonePosDataTest = new Vector2(xPos, yPos);

       
        Debug.Log("nonsense");
        while (xPos <= 3)
        {

            clone = Instantiate(enemyRef, new Vector2(xPos, yPos), transform.rotation) as Rigidbody2D;

            ++xPos;
            Debug.Log(xPos);

        }
        Debug.Log(xPos);

    }
    */
    void Update()
    {
        speed = 15 * Time.deltaTime;
        ReadEnemyPos();
      
        
    }

    void ReadEnemyPos()
    {
        for (int i = 0; i <= 2; i++)
        {
            for (int J = 0; J <= 2; J++)
            {


                ClonePosData = gameObjPos[i, J];

            }

        }
    }

    //this functions contains the set of instructions to spawn all the objects in the  level 
    public void CreateLevel()
    {

        //this is a nested for loop for itarating through the array that contains the spwan positions 
          for (int i = 0; i <= 3; i++)
           {
               for (int J = 0; J <= 5; J++)
               {

           //   this is creates a clone of our enemys in the scene 
                if (J <= 4 && i <= 3)
                {
                    ClonePosData = gameObjPos[i, J];
                    Rigidbody2D clone;
                    clone = Instantiate(enemyRef, ClonePosData, transform.rotation) as Rigidbody2D;
                }

    
                //this is creates a clone of our player in the scene 
                if (J == 3 && i == 3)
                {
                    ClonePosData = gameObjPos[4, 0];
                    Rigidbody2D clone;
                    clone = Instantiate(playerSpawnObjRef, ClonePosData, transform.rotation) as Rigidbody2D;
                }
                //this is creates a clone of our ball in the scene 
                if (J == 3 && i == 3)
                {
                    ClonePosData = gameObjPos[4, 1];
                    Rigidbody2D clone;
                    clone = Instantiate(ballRef, ClonePosData, transform.rotation) as Rigidbody2D;
                }
                //this is creates a clone of our topwall in the scene 
                if (J == 5 && i == 2)
                {
                    ClonePosData = gameObjPos[5, 2];
                    
                    topWallClone = Instantiate(topwallRef, ClonePosData, transform.rotation) as Rigidbody2D;
                   
                }

                //this is creates a clone of our rightwall in the scene 
                if (J == 5 && i == 1)
                {
                    ClonePosData = gameObjPos[5, 1];

                    clone = Instantiate(rightwallRef, ClonePosData, transform.rotation) as Rigidbody2D;

                }
                //this is creates a clone of our leftwall in the scene 
                if (J == 5 && i == 0)
                {
                    ClonePosData = gameObjPos[5, 0];

                    clone = Instantiate(leftwallRef, ClonePosData, transform.rotation) as Rigidbody2D;

                }
                //this is creates a clone of our background in the scene 

                if (J == 5 && i == 3)
                {
                    ClonePosData = gameObjPos[5, 3];

                    backGroundClone = Instantiate(backGroundRef, ClonePosData, transform.rotation) as Rigidbody2D;

                }

             }

         }
        //we correct missaligned objects here
        backGroundClone.transform.position += new Vector3(0, 0, 12);
 topWallClone.transform.Rotate(new Vector3(0, 0, 90));
    }


    public static void Movement()
    {
        xMovement = Input.GetAxis("Horizontal") * speed;
       playerref.transform.position += new Vector3(xMovement, 0, 0);
    }
    
}
