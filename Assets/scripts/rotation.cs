using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    void Update()
    {
        x += Time.deltaTime * 70;
        y += Time.deltaTime * 80; 
        z += Time.deltaTime * 90; 
        transform.rotation = Quaternion.Euler(x, y, z);
    }

}
