using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMove : MonoBehaviour
{
    public GameObject kuriko;
    GameObject Stone;
    bool fly = false;
    // Use this for initialization
    void Start()
    {
        kuriko = GameObject.Find("KURIKO");
    }

    // Update is called once per frame
    void Update()
    {
        if(kuriko.transform.position.x >= 29.0f && kuriko.transform.position.y >=3.6f)
            transform.Translate(new Vector3(0.0f, 0.1f, 0.0f));
    }

}