using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour {

    //Rigidbody rb;
    // Use this for initialization
    void Start () {
        //rb = GetComponent<Rigidbody>();
        //5초뒤 생성된 박스 파괴
        Destroy(gameObject, 7);
	}
	
	// Update is called once per frame
	void Update () {
  
    }
    void Create()
    {
            Invoke("Create", 1.0f);
            Vector2 position = transform.position;
            position = new Vector2(position.x, position.y);
            transform.position = position;
    }
}
