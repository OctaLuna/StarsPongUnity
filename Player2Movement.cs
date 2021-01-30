using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    //VARIABLES//
    //speed
    public float Speed;
    //es la variable que hace referencia a el movimiento Vertical de un objeto
    private const string Vertical = "Vertical";
    //Restricciones de movimiento vertical
    public float UpRestri;
    public float DownRestri;


    // Update is called once per frame
    void Update()
    { 
        float PlayerController = Input.GetAxisRaw(Vertical) * Speed * Time.deltaTime;

        this.transform.Translate(new Vector3(0, Mathf.Clamp(PlayerController, UpRestri, DownRestri), 0));
        //transform.position = new Vector3(transform.position.x, Input.GetAxisRaw(Vertical) * Speed * Time.deltaTime, transform.position.z);

    }
}
