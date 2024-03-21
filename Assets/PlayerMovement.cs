using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    Vector2 movement;
    public ContactFilter2D moveFilter;
    private List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal"); // returns -1 if moving left & returns 1 if moving right
        movement.y = Input.GetAxisRaw("Vertical"); // returns -1 if moving down & returns 1 if moving up
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * moveSpeed * Time.fixedDeltaTime));
        //bool success = playerMovement(movement);

    }
    /*
    private bool playerMovement(Vector2 direction)
    {
         int count = rb.Cast(direction, moveFilter,castCollisions, direction * Time.fixedDeltaTime);
        if (count == 0) { //No collisions, move as usual
            // Movement
            rb.MovePosition(rb.position + (direction * moveSpeed * Time.fixedDeltaTime));
            return true;
        }
        else {
            return false;
        }
    }
    */
}
