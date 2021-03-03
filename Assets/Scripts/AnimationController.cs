﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.Play("Buka");
    }

    // Update is called once per frame
    void Update()
    {
        // anim.PlayInFixedTime("Base Layer.Buka", 0, 0);
    }
}
