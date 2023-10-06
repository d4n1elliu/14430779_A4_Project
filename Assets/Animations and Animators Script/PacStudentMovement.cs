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

        //Set initial spawnpoint of player to (0, -9, 0) 
        transform.position = new Vector3(0f, -9f, 0f);
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
        transform.position += movement * Time.deltaTime * 1; // Adjust 'speed' according to your preference
    }
}
