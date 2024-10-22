using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (animationVariable < 2)
        {
            animationVariable++;
        }
        else
        {
            animationVariable = 0;
        }
        animator.SetInteger("isInt", animationVariable);
    }
}
