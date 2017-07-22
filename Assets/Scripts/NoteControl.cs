// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteControl : MonoBehaviour
{
    private Animator animator;
    
    void Start()
    {
        
    }

    void OnEnable()
    {
        animator = GetComponentInChildren<Animator>();
        animator.Play("Happy");
        Debug.Log("OnEnable");
    }

    void OnDisable()
    {
        animator = GetComponentInChildren<Animator>();        
        Debug.Log("OnDisable");
    }

    public void PlayAnimation(string animationName)
    {
        animator.Play(animationName);
    }

    public void FoundMarker()
    {
        //if (animCoroutine != null)
        //{
        //    StopCoroutine(animCoroutine);
        //}
        //StopCoroutine(animCoroutine);
        //ARPanelObject.transform.position = transform.position;
        //ARPanelObject.transform.rotation = transform.rotation;
        //ARPanelObject.transform.gameObject.SetActive(true);
        //ARPanelObject.PlayAnimation("Appear");
    }

    public void LostMarker()
    {
        
    }

    IEnumerator AnimationCoroutine(int i)
    {
        //ARPanelObject.PlayAnimation("Disappear");
        //Debug.LogFormat("AnimStart: {0}", Time.time);
        //yield return new WaitWhile(() => ARPanelObject.animator.GetCurrentAnimatorStateInfo(0).IsName("Disappear"));
        //Debug.LogFormat("Anim  End: {0}", Time.time);

        //ARPanelObject.transform.gameObject.SetActive(false);
        //animCoroutine = null;
        yield return null;
    }
}
