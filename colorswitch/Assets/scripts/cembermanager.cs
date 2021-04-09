using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cembermanager : MonoBehaviour
{
    public float donushizi;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, donushizi);
    }
}
