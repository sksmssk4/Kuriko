using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStone2 : MonoBehaviour {
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
            transform.Translate(new Vector3(0.0f, 0.05f, 0.0f));
            if (transform.position.y > 18.0)
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
            transform.Translate(new Vector3(0.0f, -0.05f, 0.0f));
            if (transform.position.y < 5.0)
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
