using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    //public GameObject Propeller;
    public float speed = 1500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sources: Used google to find out that the Z-Axis is also called "forward"
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
