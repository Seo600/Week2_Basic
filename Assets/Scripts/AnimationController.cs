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
        SetValue(animationVariable);
        animator.SetInteger("isInt", animationVariable);
    }

    public void SetValue(int value)
    {
        
    }
}
