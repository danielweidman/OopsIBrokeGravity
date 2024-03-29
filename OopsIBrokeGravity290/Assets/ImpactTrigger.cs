﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactTrigger : MonoBehaviour
{
    AudioSource bump;
    // Start is called before the first frame update
    void Start()
    {
        bump = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D  collision)
    {
        if (collision.relativeVelocity.magnitude > 2)
        {
            bump.Play();
        }
    }

}
