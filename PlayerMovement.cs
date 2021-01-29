using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //VARIABLES//
    //estas variables es para poner restricciones en los bordes del la camara para que el player solo se vea en pantalla
    public float UpRestri;
    public float DownRestri;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(MousePosition.y, DownRestri, UpRestri), transform.position.z);
    }
}
