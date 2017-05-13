﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    Animator animator;
    Rigidbody rb;
    public GameObject KuriKo;
    public GameObject CreateBox; // prefab
    public GameObject CreateBoxPosition;
    public float health = 1; // 체력
    
    float directionX = 0;
    float directionY = 0;
    bool walking = false;
    float Speed = 8.0f; // 걷는 속도
    float J_P = 10.0f; // 점프력

    bool death;



    void Start()
    {
        death = false;
    }
	// Use this for initialization
	void Awake () {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();  // rigidbody에서 지원하는 AddForce를 사용하기 위해
    }

    // Update is called once per frame
    void Update()
    {

        if (death == true) // 죽었을때 동작 정지
        {
            return;
        }

        else // 죽지않았을경우 (death == false)
        {

            if (animator)
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");
                walking = true;
                if (h > 0)
                {
                    directionX = 1;
                    directionY = 0;
                }
                else if (h < 0)
                {
                    directionX = -1;
                    directionY = 0;
                }
                //else if(v>0)
                //{
                //    directionX = 0;
                //    directionY = 1;
                //}

                else
                {
                    walking = false;
                }

                if (walking)
                {
                    transform.Translate(new Vector3(directionX, 0.0f, 0.0f) * Time.deltaTime * Speed);
                }

                animator.SetFloat("DirectionX", directionX);
                animator.SetFloat("DirectionY", v);
                animator.SetBool("Walking", walking);
            }

            if (Input.GetKeyDown(KeyCode.Space)) // 스페이스를 Down(누르면)하면 동작
            {
                rb.AddForce(Vector3.up * J_P, ForceMode.Impulse); // 위쪽방향으로 J_P값만큼 점프한다.
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                GameObject BoxPosition = (GameObject)Instantiate (CreateBox);
                BoxPosition.transform.position = CreateBoxPosition.transform.position;
            }


        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            animator.SetBool("Dies", true);
            death = true;
        }
    }
}
