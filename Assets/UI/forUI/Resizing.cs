using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizing : MonoBehaviour {

	private SpriteRenderer _mySpriteRender;

	void Start()
	{
		Rect bound = Utility.bound3D (-Camera.main.transform.position.z);

		_mySpriteRender = GetComponent<SpriteRenderer> ();
		transform.localScale = Utility.FullSizeSprite (transform.localScale,_mySpriteRender,bound);
	}

}
