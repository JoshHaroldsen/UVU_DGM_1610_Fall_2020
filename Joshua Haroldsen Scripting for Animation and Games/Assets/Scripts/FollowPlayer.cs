﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // Makes the camera follow the vehicle
    private Vector3 offset = new Vector3(0, 5, -10);

    // Update is called once per frame
    void Update()
    {
        // Makes the main camera follow the player position
        transform.position = player.transform.position + offset;
    }
}
