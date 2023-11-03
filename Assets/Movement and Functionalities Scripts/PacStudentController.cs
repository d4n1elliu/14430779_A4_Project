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

    //Duration of the movement tween
    public float moveDur = 0.5f;

    private Tweener tweener;

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

        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementInput();
    }

    private void MovementInput()
    {
        //Check for player input
        float horiInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");



    }
}
