using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15;
    private float turnSpeed = 30;
    // horizontal input
    private float hInput;
    // forward input
    private float fInput;

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

        // Moves the vehicle foward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        // Rotates the vehicle left and right based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * hInput);
    }
}
