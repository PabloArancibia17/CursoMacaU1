using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : MonoBehaviour
{
    public GameObject tank;
       
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(tank.transform.position.x, tank.transform.position.y + 10, tank.transform.position.z - 17);
        
    }
}
