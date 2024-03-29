﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMove : MonoBehaviour {

    public GameObject player;
    public float Speed;
    public bool Touching;
	// Use this for initialization
	void Start () {
        Speed = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Touching)
        {
            transform.LookAt(player.transform.position);

            transform.position -= transform.forward * Speed * Time.deltaTime;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        Touching = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Touching = false;
    }
}
