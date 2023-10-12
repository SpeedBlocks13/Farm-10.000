using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this to set the movement speed.

    private Vector3 movement;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        movement = new Vector3(horizontalInput, verticalInput, 0).normalized; // Normalize the vector to ensure consistent speed in all directions.
    }

    void FixedUpdate()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        // Get the current position
        Vector3 currentPosition = transform.position;

        // Calculate the new position
        Vector3 newPosition = currentPosition + movement * moveSpeed * Time.fixedDeltaTime;

        // Move the character
        transform.position = newPosition;
    }
}
