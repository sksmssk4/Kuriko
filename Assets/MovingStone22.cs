using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStone22 : MonoBehaviour {
    public float Speed = 3.0f;
    bool left = true;
    bool right = false;
    // Use this for initialization
    void Start()
    {

    }
    void Block_left()
    {
        if (left == true)
        {
            transform.Translate(new Vector3(-Speed * Time.deltaTime, 0.0f, 0.0f));
            if (transform.position.x < -46.0f)
            {
                left = false;
                right = true;
            }
        }
    }
    void Block_right()
    {
        if (right == true)
        {
            transform.Translate(new Vector3(Speed * Time.deltaTime, 0.0f, 0.0f));
            if (transform.position.x > -30.0f)
            {
                left = true;
                right= false;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Block_left();
        Block_right();
    }
}
