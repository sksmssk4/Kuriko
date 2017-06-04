using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void timestop(){

		Time.timeScale = 0;
	}

	public void timeflow(){

		Time.timeScale = 1;
	}
}
