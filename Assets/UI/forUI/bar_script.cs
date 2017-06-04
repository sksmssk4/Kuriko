using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bar_script : MonoBehaviour {

	public AudioSource bgm;
	private Image bar;
	public float max_volume=100f;
	public static float cur_volume;
	private static float myvolume;

	// Use this for initialization
	void Start () {
		cur_volume = max_volume;
		myvolume=(cur_volume/max_volume)/1;
		bar = GetComponent<Image> ();
		bar.fillAmount = Mathf.SmoothStep(bar.fillAmount,myvolume,10*Time.deltaTime);

	}
	
	// Update is called once per frame
	void Update () {

		bgm.volume = myvolume;

	}

	public void Sound_down() {

		if (cur_volume > 0f) {
			cur_volume -= 10;
		}
		myvolume=(cur_volume/max_volume)/1;
		bar.fillAmount = myvolume;
	}

	public void Sound_up() {

		if (cur_volume < max_volume) {
			cur_volume += 10;
		}
		myvolume=(cur_volume/max_volume)/1;
		bar.fillAmount = myvolume;
	}

}
