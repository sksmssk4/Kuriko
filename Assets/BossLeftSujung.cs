using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLeftSujung : MonoBehaviour {

    private AudioSource audio_Break;
    public AudioClip audio_Breaking;

    Animator animator;
    Rigidbody rb;
    GameObject Sujung;


    public Animator anim; // 헤딩액티브
    public bool Heading;
    public float HeadTimer = 0;
    public float HeadCd = 2f;

    void Awake()
    {
        Heading = false;
        animator = GetComponent<Animator>();
    }


    // Use this for initialization
    void Start()
    {
        this.audio_Break = this.gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && !Heading)
        {
            Heading = true;
            HeadTimer = HeadCd;

        }
        if (Heading)
        {
            if (HeadTimer > 0)
            {
                HeadTimer -= Time.deltaTime;

            }

            else
            {
                Heading = false;
            }
        }
    }

    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Kuriko" && Heading == true)
        {
                animator.SetBool("Breaking", true);
                DestroyObject(gameObject, 3.0f);
        }
    }
    */
    void OnTriggerStay(Collider other) // 충돌박스 내부에 있을경우 (Enter)는 들어가는 즉시 이고 Stay는 박스안에 머무를경우
    {

        if (other.tag == "Kuriko" && Heading == true)
        {
            animator.SetBool("LeftBreaking", true);
            DestroyObject(gameObject, 3.0f);
            this.audio_Break.clip = this.audio_Breaking;
            this.audio_Break.loop = false;
            this.audio_Break.Play();
        }
    }
}

