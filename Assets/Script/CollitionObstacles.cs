using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionObstacles : MonoBehaviour
{

    
    
    public GameObject tank;

   
    public void OnCollisionEnter(Collision collision)
    {
        tank.transform.position = new Vector3(0, 0, 0);
        Debug.Log("choque");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
