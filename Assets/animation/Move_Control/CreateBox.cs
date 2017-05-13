using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour {


	// Use this for initialization
	void Start () {
        //5초뒤 생성된 박스 파괴
        Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = transform.position;
        position = new Vector2(position.x, position.y);
        transform.position = position;
    }
}
