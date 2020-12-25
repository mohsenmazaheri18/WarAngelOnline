﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorSciFi : MonoBehaviour
{
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Debug.Log("Col");
            anim.SetBool("Go", true);
        }
        

    }
    public void OnCollisionExit(Collision other)
    {

      
    }
}
