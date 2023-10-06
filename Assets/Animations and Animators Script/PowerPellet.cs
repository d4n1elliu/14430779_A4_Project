using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        transform.position = new Vector3(0f, 3f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
