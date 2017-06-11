using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriestWalk2 : MonoBehaviour {
    Animator animator;

    float pdirectionX;
    bool pwalking = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void PMove()
    {
        if (animator)
        {
            if (transform.position.x < -76.3f)
            {
                pdirectionX = 5.0f;
            }
            else if (transform.position.x > -59.2f)
            {
                pdirectionX = -5.0f;
            }
            if (transform.position.x == -10.6f) // 프리스트 대기 실패
            {
                pwalking = false;
            }
            else
            {
                pwalking = true;
            }
            if (pwalking = true)
            {
                transform.Translate(new Vector3(pdirectionX * Time.deltaTime, 0.0f, 0.0f));
            }

            animator.SetFloat("DirectionX", pdirectionX);
            animator.SetBool("Walking", pwalking);
        }
    }
    void Update()
    {
        PMove();
    }
}
