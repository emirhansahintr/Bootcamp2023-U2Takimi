using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 4.5f;
    public float sprint = 6f;
    public float walkspeed = 4.5f;
    public float slowspeed = 2.5f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;


    Vector3 velocity;
    public bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        //Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        //Run
        if (Input.GetKey(KeyCode.LeftShift) && isGrounded && speed == 4.5f)
        {
            speed = sprint;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = walkspeed;
        }
        //Slow
        if (Input.GetKey(KeyCode.LeftControl) && isGrounded && speed == 4.5f)
        {
            speed = slowspeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed = walkspeed;
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
