using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriestWalk2 : MonoBehaviour {
    Animator animator;

    float pdirectionX = 0;
    bool pwalking = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void PMove()
    {
        if (animator)
        {
            if (transform.position.x < -69.0f)
            {
                pdirectionX = 0.05f;
            }
            else if (transform.position.x > -56.0f)
            {
                pdirectionX = -0.05f;
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
                transform.Translate(new Vector3(pdirectionX, 0.0f, 0.0f));
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
