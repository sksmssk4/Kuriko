using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class movieclip2 : MonoBehaviour {

	public VideoPlayer vp;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(vp.isPlaying==false)
			SceneManager.LoadScene ("Title");
	}
}
