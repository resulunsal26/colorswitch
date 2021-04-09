using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform toppozisyon;
    

    // Update is called once per frame
    void Update()
    {
        if(toppozisyon.position.y>transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, toppozisyon.position.y, transform.position.z);
        }
    }
}
