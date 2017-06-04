using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextstage : MonoBehaviour {

	public Canvas NStage;
	public Canvas Stage;
	public bool Next;
	public GameObject NButton;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Gonext()
	{

		Next = false;

		if(Next==false)
		{
			Next = true;

			Stage.enabled = false;
			NStage.enabled = true;

		}
		else if(Next==true)
		{
			Next = false;
			Stage.enabled = true;
			NStage.enabled = false;

		}
	}

}
