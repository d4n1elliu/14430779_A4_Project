using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet4 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //Setting initial spawnpoint to (-16, -8, 0)
        transform.position = new Vector3(-16f, -8, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
