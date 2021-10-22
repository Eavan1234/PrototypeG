using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
    float speed = 2.0f;
    float moveSpeed = 2.0f;
    public float JumpGravity = 500f;
    public Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {
    rg = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
       if (Input.GetKeyDown(KeyCode.W) ){
 　　　　    rg.velocity = new Vector3(rg.velocity.x, JumpGravity * Time.deltaTime,rg.velocity.y);
        }
        
        /*if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }*/
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}
