﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Ctrl : MonoBehaviour {
    float x = 0.0f;
    public GameObject kuriko;
    Vector3 NewPosition;
    Vector3 ClampPosition;
    // Use this for initialization
    void Start () {
        kuriko = GameObject.Find("KURIKO");
		
	}
	
	// Update is called once per frame
	void Update () {
        //x = Mathf.Clamp(x, 0.0f, 10.0f);
        // NewPosition =  kuriko.transform.position + new Vector3(0.0f, 2.9f, -2.6f);


        transform.position = new Vector3(Mathf.Clamp(kuriko.transform.position.x, -50.0f, 1.70f), kuriko.transform.position.y + 2.9f, kuriko.transform.position.z - 2.6f);


    }
}
