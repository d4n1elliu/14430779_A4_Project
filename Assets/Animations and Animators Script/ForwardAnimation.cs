using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardAnimation : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //Check if the animator component is not null and then play animation
        animator = GetComponent<Animator>();

        if (animator != null)
        {
            animator.SetTrigger("MoveForward");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
