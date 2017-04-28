using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bigdaddymovin : MonoBehaviour
{
    NavMeshAgent agent;
    Vector3 destination;
    Animator animator;
    GameObject canvas;
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        canvas = GameObject.FindWithTag("Finish");
        canvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        if(Input.GetKeyDown("q"))
        {
            Application.Quit();
        }
     

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                animator.SetBool("click", true);
                agent.destination = hit.point;
                destination = agent.destination;
            }
        }

        if(gameObject.transform.position == destination)
        {
            animator.SetBool("click", false);
        }


    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "grannies(Clone)")
        {
            canvas.SetActive(true);
        }

    }
}
