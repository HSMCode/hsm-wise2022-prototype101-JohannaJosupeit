using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float horizontalInput, forwardInput, Speed, turnSpeed, JumpHeight;
    public Animator Animator;
    public Rigidbody rb;
    public LayerMask GroundMask;
    public bool isGrounded;
    public Transform GroundCheck;
    public float GroundDistance;

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        Speed = 8f;
        turnSpeed = 230f;
        JumpHeight = 4f;
        GroundDistance = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //GroundCheck
        isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);

        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * Speed);
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);

        if (Input.GetButton("Jump") && isGrounded)
        { 
            rb.velocity = new Vector3(rb.velocity.x, JumpHeight, rb.velocity.z);
            
        }

        

        if (forwardInput > 0 || forwardInput < 0)
        {
            Animator.SetBool("isRunning", true);
        }
        else
        {
            Animator.SetBool("isRunning", false);
        }
        
        if (isGrounded)
        {
            Animator.SetBool("isJumping", false);
            
        }
        else
        {
            Animator.SetBool("isJumping", true);
            
        }

      
        
    }
}
