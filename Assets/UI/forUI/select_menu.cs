using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select_menu : MonoBehaviour {

	public Canvas backgroundCanvas;
	public Canvas stageCanvas;
	public Canvas stage2Canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void select_start(){

		backgroundCanvas.enabled = true;
		stageCanvas.enabled = true;
	}

	public void menu_disabled(){

		backgroundCanvas.enabled = false;
		stageCanvas.enabled = false;
		stage2Canvas.enabled = false;
	}
}
