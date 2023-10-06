using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet2 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        transform.position = new Vector3(-16f, 12f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
