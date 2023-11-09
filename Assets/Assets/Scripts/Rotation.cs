using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
   // public float rotationSpeed = 10f;
    // Start is called before the first frame update
    public GameObject Wheel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Wheel.transform.Rotate(0,0,0.1f,Space.Self);
    }
}
