using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet3 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //Setting initial spawnpoint to (17, -8, 0)
        transform.position = new Vector3(17f, -8f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
