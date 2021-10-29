using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 50);
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0f, 0f);
    }
}
