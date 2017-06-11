using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBossAttack : MonoBehaviour {

    public GameObject BossBullet; // BULLET position
    public GameObject BossMissilePos; // BULLET position prefab

    public Animator anim;


    public bool Attack;
    public float AttackTimer;
    public float AttackCd;

    // Use this for initialization



    void Start()
    {
        Attack = false;
        AttackTimer = 0;
        AttackCd = 2f;
        InvokeRepeating("Fire", 1, 2.0f);
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once perframe
    void Update()
    {

    }


    void Fire()
    {
        GameObject bossbullet01 = (GameObject)Instantiate(BossBullet);
        if (!Attack)
        {
            Attack = true;
            AttackTimer = AttackCd;
        }

        if (Attack)
        {
            if (AttackTimer > 0)
            {
                AttackTimer -= Time.deltaTime;
            }
            else
            {
                Attack = false;
            }
        }
        anim.SetBool("Attack", Attack);
        bossbullet01.transform.position = BossMissilePos.transform.position;
    }
}
