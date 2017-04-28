using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class granny : MonoBehaviour {
    Transform bigDaddy;
    Vector3 destination;
    Animator animator;
    Rigidbody rb;
    RigidbodyConstraints rbC;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rbC = rb.constraints;
    }

    // Update is called once per frame
    void Update()
    {
        bigDaddy = GameObject.Find("Big_Vegas").transform;
        float distance = Vector3.Distance(bigDaddy.position, gameObject.transform.position);
        rb.freezeRotation = true; 

        if (distance <= 5)
        {
            animator.SetBool("inFive", true);
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, bigDaddy.position * 1.9f, .02f);
            //gameObject.transform.LookAt(bigDaddy);
            gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, Quaternion.LookRotation(bigDaddy.position - gameObject.transform.position), .75f * Time.deltaTime);
        } else
        {
            animator.SetBool("inFive", false);
        }

        if (!Physics.Raycast(gameObject.transform.position, Vector3.down))
        {
            rb.freezeRotation = false;
            animator.SetTrigger("freefall");
        }
    }

  
}
