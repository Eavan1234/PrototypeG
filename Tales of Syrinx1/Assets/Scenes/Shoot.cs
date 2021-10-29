using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Shoot : MonoBehaviour
{
    int speed=10;
public Rigidbody Bullet;
public Transform fire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Rigidbody clone;
            clone=(Rigidbody)Instantiate(Bullet,fire.position,fire.rotation);
            clone.velocity=transform.TransformDirection(Vector3.forward*50);
        }  
    }
}
