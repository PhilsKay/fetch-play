using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float bottomLimit = 0;
    private float leftLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.z < leftLimit)
        {
            Destroy(gameObject);
        }

    }
}
