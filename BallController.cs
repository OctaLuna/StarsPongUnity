using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //VARIABLES 
    //Posicion de el player 
    public Transform PlayerPosition;
    //Esta es la variable para que inicie el juego
    private bool GameStar = false;
    //esto hace una referencia a el RigidBody de la pelota 
    public Rigidbody2D RBBall;
    //Velocidad de la pelota en "x" y "y"
    public float SpeedBallX = 30;
    public float SpeedBallY = 30;

    // Update is called once per frame
    void Update()
    {
        if(GameStar == false){
            float PositionBallx = PlayerPosition.transform.position.x - transform.position.x;

            transform.position = new Vector3(PlayerPosition.position.x - PositionBallx, PlayerPosition.position.y, transform.position.z);

            if(Input.GetMouseButtonDown(0)){
                RBBall.velocity = new Vector2(15, 15);
                GameStar = true;
            }
        }        
    }
}
