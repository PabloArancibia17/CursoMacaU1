using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float velocidadH = 10, velocidadV = 10;
    float moveTankH, moveTankV;
    
  
    public void MoveVertical()
    {
        moveTankV = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * moveTankV * velocidadV * Time.deltaTime);


    }

    public void MoveHorizontal()
    {
        moveTankH = Input.GetAxis("Horizontal");
        if (moveTankV != 0)
        {
            transform.Rotate(Vector3.up * moveTankH, velocidadH * Time.deltaTime);

        }
    }

        

    void Update()
    {
        MoveHorizontal();
        MoveVertical();
        
    }
}
