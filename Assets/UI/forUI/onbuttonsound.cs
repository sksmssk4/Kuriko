using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class onbuttonsound : MonoBehaviour {

	// Use this for initialization

	public AudioClip sound;

	public Button button {get { return GetComponent<Button>();}}
	public AudioSource source {get { return GetComponent<AudioSource> ();}}

	void Start () {
		gameObject.AddComponent<AudioSource> ();
		source.clip = sound;
		source.playOnAwake = false;

		button.onClick.AddListener (() => PlaySound ());
	}

	// Update is called once per frame
	void Update () {
		
	}

	void PlaySound()
	{
		source.PlayOneShot (sound);

	}
}
