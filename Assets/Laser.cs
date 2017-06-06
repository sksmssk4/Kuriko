using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    public bool OFF;

    public float OFFTimer;
    public float OFFCd;

    GameObject laser;


    void Awake()
    {
        OFF = false;
    }

    // Use this for initialization
    void start()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.X) && !OFF)
        {
            OFF = true;
            OFFTimer = OFFCd;
        }
        if (OFF)
        {
            if (OFFTimer > 0)
            {
                OFFTimer -= Time.deltaTime;
            }

            else
            {
                OFF = false;
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Kuriko" && OFF == true)
        {
            DestroyObject(gameObject, 0.5f);
        }
    }
}