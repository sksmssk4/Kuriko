using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prestage : MonoBehaviour {

	public Canvas PStage;
	public Canvas Stage;
	public bool pre;
	public GameObject PButton;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Gopre()
	{
		pre = false;

		if(pre==false)
		{
			pre = true;

			Stage.enabled = false;
			PStage.enabled = true;

		}
		else if(pre==true)
		{
			pre = false;
			Stage.enabled = true;
			PStage.enabled = false;

		}
	}

}

