﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerControl : MonoBehaviour {

    private AudioSource audio_jump; // 오디오소스에 점프소리를 읽음
    public AudioClip Jumping; //오디오 클립이 점프소리를 읽음

    public Image currentHealthbar;
    public Text ratioText;


    Animator animator;
    Rigidbody rb;
    public GameObject KuriKo;
    //public GameObject CreateBox; // prefab
    public GameObject leftCreateBoxPosition; //방향에 따른 박스 생성위치
    public GameObject rightCreateBoxPosition;
    public Vector2 offset = new Vector2(0.4f, 0.1f);
    Transform Createpos; // //방향에 따른 박스 생성위치

    float directionX = 0;
    bool walking = false;
    public float Speed = 8.0f; // 걷는 속도 8
    public float J_P = 10.0f; // 점프력   10
    bool jumping = false;

    public float health;
    public float maxhealth;
    /*
    private float hitpoint;
    private float maxHitpoint;
    */
    bool death;
    bool facingright; // 위치 인식

    void Start()
    {
        this.audio_jump = this.gameObject.AddComponent<AudioSource>();
        health = 100.0f; // 체력
        maxhealth = 100.0f;

        death = false;
        facingright = true;
        Createpos = transform.Find("CreateBoxPosition"); //생성위치 인식하기위해서(좌우 이동시)
        UpdateHealthbar();
    }
	// Use this for initialization
	void Awake () {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();  // rigidbody에서 지원하는 AddForce를 사용하기 위해
        
    }
    void Jump()
    {
        // 죽었을때 or 'Active'라는 애니메이션이 애니메이터에서 작동될때 동작정지
        if (death == true || animator.GetCurrentAnimatorStateInfo(0).nameHash == Animator.StringToHash("Base Layer.Active"))
            return;
        else // 아닐 때
        {
            if (jumping == false && Input.GetKeyDown(KeyCode.Space)) // 스페이스를 Down(누르면)하고 Jumping == false일 떄만 점프동작
            {
                jumping = true;
                rb.AddForce(Vector3.up * J_P, ForceMode.VelocityChange); // 위쪽방향으로 J_P값만큼 점프한다.
                this.audio_jump.clip = this.Jumping; // 오디오클립이 점프하는사운드를 읽음
                this.audio_jump.loop = false; // 반복재생 안함
                this.audio_jump.Play(); // 점프할 때 만 사운드를 재생
            }
            if (rb.velocity.y == 0)
            {
                jumping = false;
            }
        }
    }
    void Move()
    {
        // 죽었을때 or 'Active'라는 애니메이션이 애니메이터에서 작동될때 동작정지
        if (death == true || animator.GetCurrentAnimatorStateInfo(0).nameHash == Animator.StringToHash("Base Layer.Active")) 
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
                    facingright = true;


                }
                else if (h < 0)
                {
                    directionX = -1;
                    facingright = false;

                }
                else
                {
                    walking = false;
                }

                if (walking)
                {
                    transform.Translate(new Vector3(directionX, 0.0f, 0.0f) * Time.deltaTime * Speed);
                    //transform.localScale = new Vector3(0.5f * directionX, 0.5f, 1.0f);
                }
                animator.SetFloat("DirectionX", directionX);
                animator.SetBool("Walking", walking);
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        //죽을경우
        if(health <= 0)
        {
            Death();

        }
        Move();
        Jump();
        //Z키 누를시 박스생성 및 생성 지연시간 추가

        if (Input.GetKeyDown(KeyCode.Z))
        {
            health -= 2.0f;
            Invoke("CreateBoxFire", 1.2f); // 박스 생성지연 , 시간(1.0f초)
            //GameObject BoxPosition = (GameObject)Instantiate (CreateBox); // Z키를 누르면 박스를 생성
            //BoxPosition.transform.position = CreateBoxPosition.transform.position; 
            //CreateBoxFire(); // 아래에 있음
        }
        UpdateHealthbar();
    }

    //진입시
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            health -= 100;
            Death();           
        }
        UpdateHealthbar();
    }

    //진입상태
    void OnTriggerStay(Collider other)
    {


    }

    //박스 생성 위치변화
    void CreateBoxFire()
    {
        if (death == true)
        {
            return;
        }
        else
        {
            //오른쪽으로 보지 않을경우
            if (!facingright)
            {
                //방향조정
                transform.localScale = new Vector3(0.6f * directionX, 0.5f, 1.0f);
                //생성위치 조정
                Instantiate(leftCreateBoxPosition, Createpos.position, Quaternion.identity);  // 캐릭터앞에 ray 쏴서 박스 놓을 공간 확인
            }

            //오른쪽으로 바라볼경우
            if (facingright)
            {
                //방향 조정
                transform.localScale = new Vector3(0.6f * directionX, 0.5f, 1.0f);
                //생성 위치 조정
                Instantiate(rightCreateBoxPosition, Createpos.position * directionX, Quaternion.identity);


            }
            //위치 재조정
            transform.localScale = new Vector3(0.5f, 0.5f, 1.0f);
        }
    }


    //데스함수
    void Death()
    {
        if (health <= 0)
        {
            death = true;
            animator.SetBool("Dies", true);

			Invoke("Gogameover",1);

        }
    }

	void Gogameover()
	{
		SceneManager.LoadScene ("Gameover");
	}

    void UpdateHealthbar()
    {
        float ratio = health / maxhealth;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString("0") + ' '  + '%';
    }
}