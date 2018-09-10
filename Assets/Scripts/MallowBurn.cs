﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MallowAnimation : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    public void burn()
    {
        anim.Play("burn");
    }

    public void impact()
    {
        anim.Play("impact");
    }

    public void fall()
    {
        anim.Play("fall");
    }
}
