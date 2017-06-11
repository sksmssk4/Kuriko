using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBossMissile : MonoBehaviour {

    public int speed;
    public float delay;

	// Use this for initialization
	void Start () {

        Destroy(gameObject, delay);
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        position = new Vector3(position.x + speed * Time.deltaTime, position.y, -1);
        transform.position = position;
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Kuriko" || other.tag == "Ground")
        {
            Destroy(gameObject, 0);
        }
    }
}
