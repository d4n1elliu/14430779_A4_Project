using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class PacStudentMovement : MonoBehaviour
{
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        transform.position = new Vector3(-12.4f, 13.58f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float moveXAxis = Input.GetAxis("Horizontal");
        float moveYAxis = Input.GetAxis("Vertical");

        animator.SetFloat("DirX", moveXAxis);
        animator.SetFloat("DirY", moveYAxis);

        // Move Pac-Man
        Vector3 movement = new Vector3(moveXAxis, moveYAxis, 0f);
        transform.position += movement * Time.deltaTime * 2; // Adjust 'speed' according to your preference
    }
}
