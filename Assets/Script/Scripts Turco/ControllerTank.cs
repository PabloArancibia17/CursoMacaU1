using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTank : MonoBehaviour
{
    public float velocidad = 15, velocidadDoblar = 10;
    float giro, avanzar;
   

    // Update is called once per frame
    void Update()
    {
        giro = Input.GetAxis("Horizontal");
        avanzar = Input.GetAxis("Vertical");
        


        transform.Translate(Vector3.forward * avanzar * velocidad * Time.deltaTime);
        if ( avanzar != 0)
        {
            transform.Rotate(Vector3.up * giro * Time.deltaTime, 1);
        }
    }
}
