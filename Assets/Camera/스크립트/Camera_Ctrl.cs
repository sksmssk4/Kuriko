using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Ctrl : MonoBehaviour {
    float x = 0.0f;
    public GameObject kuriko;
    Vector3 NewPosition;
    Vector3 ClampPosition;
    // Use this for initialization
    void Start () {
        kuriko = GameObject.Find("KURIKO");
		
	}
	//카메라 위치 조정
	void Update () {
      
        transform.position = new Vector3(Mathf.Clamp(kuriko.transform.position.x, -63.0f, 13.5f), // x축으로 -63.0f이하 12.8f이상 카메라 못움직이게
            Mathf.Clamp(kuriko.transform.position.y, -28.5f, 0.0f) + 2.9f, kuriko.transform.position.z - 2.6f);

    }
}
