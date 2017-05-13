using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBox : MonoBehaviour {

    public Animator anim; 
    public Rigidbody rb;

    public bool Active = false;

    public float ActiveTimer = 0;
    public float ActiveCd = 2f;

    void Awake()
    {
        Active = false;
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Z) && ! Active)
        {
            Active = true;
            ActiveTimer = ActiveCd;

           
        }
        if(Active)
        {
            if (ActiveTimer > 0)
            {
                ActiveTimer -= Time.deltaTime;
            }

            else
            {
                Active = false;
            }
        }

        anim.SetBool("Active", Active);
    }



}
