using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeGameScene_stage01()
	{
		SceneManager.LoadScene ("kuriko");

	}

	public void ChangeGameScene_stage02()
	{
		SceneManager.LoadScene ("Stage22");

	}

	public void ChangeGameScene_seclect()
	{
		SceneManager.LoadScene ("select");

	}

	public void ChangeGameScene_title()
	{
		SceneManager.LoadScene ("title");

	}

	public void Endgame()
	{
		Application.Quit ();

	}

}
