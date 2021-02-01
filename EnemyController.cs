using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //VARIABLES//
    //Esta variable hace referencia a el trasform de la pelota
    public Transform Ball;
    //Esta es la velocidad de el  enemigo
    public float Speed;


    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.y < Ball.position.y){
            transform.position = new Vector3(transform.position.x, transform.position.y + Speed, transform.position.z);
        }
        else if(transform.position.y > Ball.position.y){
            transform.position = new Vector3(transform.position.x, transform.position.y - Speed, transform.position.z);
        }
        
    }
}
