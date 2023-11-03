using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float orthographicSize = 16f;
    // Start is called before the first frame update
    void Start()
    {
        Camera mainCamera = GetComponent<Camera>();

        if (mainCamera != null)
        {
            // Set the orthographic size to the target size
            mainCamera.orthographicSize = orthographicSize;
        }
        else
        {
            // Log an error if the Camera component is not found
            Debug.LogError("Camera component not found!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
