using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y < -19.61)
            transform.Translate(new Vector3(0.0f, 0.05f, 0.0f));

    }
}
