using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverHit : MonoBehaviour
{

    public Animator anim;
    public Rigidbody rb;

    public bool Hit;

    public float HitTimer;
    public float HitCd;


    void Awake()
    {
        Hit = false;
        HitTimer = 0;
        HitCd = 10.0f;
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X) && !Hit)
        {
            Hit = true;
            HitTimer = HitCd;
        }
        if (Hit)
        {
            if (HitTimer > 0)
            {
                HitTimer -= Time.deltaTime;
            }

            else
            {
                Hit = false;
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Kuriko" && Hit == true)
        {
            anim.SetBool("Hit", true);
        }
    }
}
