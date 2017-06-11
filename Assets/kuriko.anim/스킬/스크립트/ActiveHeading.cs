using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveHeading : MonoBehaviour
{

    public Animator anim;
    public Rigidbody rb;

    public bool Heading;

    private AudioSource audio_Achieve;
    public AudioClip audio_Achieving;


    private AudioSource audio_bAchieve;
    public AudioClip audio_bAchieving;

    bool death;

    public float HeadTimer = 0;
    public float HeadCd = 2f;

    void Awake()
    {
        Heading = false;
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        death = false;
    }


    // Use this for initialization
    void Start()
    {
        this.audio_Achieve = this.gameObject.AddComponent<AudioSource>();
        this.audio_bAchieve = this.gameObject.AddComponent<AudioSource>();
    }

    void Achieving()
    {
        this.audio_Achieve.clip = this.audio_Achieving;
        this.audio_Achieve.loop = false;
        this.audio_Achieve.Play();
    }

    void bAchieving()
    {
        this.audio_bAchieve.clip = this.audio_bAchieving;
        this.audio_bAchieve.loop = false;
        this.audio_bAchieve.Play();
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
        anim.SetBool("Heading", Heading);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Sujung" && Heading == true)
        {
            Invoke("Achieving", 0.8f);
        }

        if (other.tag == "BossSujung" && Heading == true)
        {
            Invoke("bAchieving", 0.8f);
        }
    }
}