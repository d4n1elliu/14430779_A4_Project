using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour
{
    public int targetHeight = 491; // Set this to the number of vertical pixels in your resolution.

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the camera size based on the target height.
        Camera.main.orthographicSize = targetHeight / 2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
