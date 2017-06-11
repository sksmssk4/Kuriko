using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStone5 : MonoBehaviour {
    public float Speed = 3.0f;
    bool up = true;
    bool down = false;
    // Use this for initialization
    void Start()
    {

    }
    void Block_up()
    {
        if (up == true)
        {
            transform.Translate(new Vector3(0.0f, Speed * Time.deltaTime, 0.0f));
            if (transform.position.y > 48.5f)
            {
                up = false;
                down = true;
            }
        }
    }
    void Block_down()
    {
        if (down == true)
        {
            transform.Translate(new Vector3(0.0f, -Speed * Time.deltaTime, 0.0f));
            if (transform.position.y < 34.0f)
            {
                up = true;
                down = false;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Block_up();
        Block_down();
    }
}
