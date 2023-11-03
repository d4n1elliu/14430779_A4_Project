using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
public class PacStudentController : MonoBehaviour
{
    private Animator animator;
    //Initial movement speed for pacman
    public float moveSpeed = 5f; 

    //Plays the pellet eating sound
    public AudioClip pelletEatingSound;

    //Plays the moving pacman sound
    public AudioClip movingSound;

    //Direction where pacman can move
    public enum Directions { Up, Down, Left, Right };

    //Current position pacman is in
    private Vector3 targetPos;

    //Next postion pacman is in
    private Vector3 nextGridPos;

    //Saves the input entered in keyboard
    private Vector3 lastInput = Vector3.zero;

    //Default movement direction
    public Directions initialMoveDir = Directions.Right;

    //Set the pac man to not move
    public bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //Set initial spawnpoint of player to (-12.4f, 13.58f, 0f)
        transform.position = new Vector3(-12.4f, 13.58f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //MovementInput();
    }

    /*private void MovementInput()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (CanMoveInThisDirection(Directions.Right))
            {
                initialMoveDir = Directions.Right;
            }
        }

        else if (Input.GetAxis("Horizontal") > 0)
        {
            if (CanMoveInThisDirection(Directions.Left))
            {
                initialMoveDir = Directions.Right;
            }
        }

        else if (Input.GetAxis("Vertical") > 0)
        {
            if (CanMoveInThisDirection(Directions.Up))
            {
                initialMoveDir = Directions.Up;
            }
        }

        else if (Input.GetAxis("Vertical") > 0)
        {
            if (CanMoveInThisDirection(Directions.Down))
            {
                initialMoveDir = Directions.Down;
            }
        }
    }*/
}
