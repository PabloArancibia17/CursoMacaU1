using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConfig : MonoBehaviour
{
    public GameObject tank;
    public float compZ = 18;
    public float compY = 8;
    public float rotTankX = 11;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.right, rotTankX);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(tank.transform.position.x, tank.transform.position.y + compY, tank.transform.position.z - compZ);
    }
}
