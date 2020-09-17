using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    
    // Sets the position of the camera
    private Vector3 offset = new Vector3(120, 2, -1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Makes the camera follow the plane's position
        transform.position = plane.transform.position + offset;
    }
}
