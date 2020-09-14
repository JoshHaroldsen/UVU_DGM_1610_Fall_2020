using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15;
    public float turnSpeed;
    // horizontal input
    public float hInput;
    // forward input
    public float fInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moves vehicle left and right
        hInput = Input.GetAxis("Horizontal");

        // moves vehicle forward and backward
        fInput = Input.GetAxis("Vertical");

        // Move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * hInput);
    }
}
