using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Ctrl : MonoBehaviour {
    float x = 0.0f;
    public GameObject kuriko;
    // Use this for initialization
    void Start () {
        kuriko = GameObject.Find("KURIKO");
		
	}
	
	// Update is called once per frame
	void Update () {
        x = Mathf.Clamp(x, 0.0f, 10.0f);
        this.transform.position = kuriko.transform.position + new Vector3(0.0f, 2.9f, -2.6f);
       


    }
}
