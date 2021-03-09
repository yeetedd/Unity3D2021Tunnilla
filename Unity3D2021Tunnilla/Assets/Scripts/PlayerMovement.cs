using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public GameObject camera;

    public float speed = 8f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    float raycastDistance = 1f;    //private was taken away

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 velocity;
    private bool isGrounded = true;

    private Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        int layerMask = 1 << 8;

        RaycastHit hit;

        if(Physics.Raycast(groundCheck.position, groundCheck.TransformDirection(Vector3.down), out hit, raycastDistance, layerMask))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

    }

    private void Update()
    {
        //putoaminen
        if(isGrounded  && velocity.y < 0)
        {
            velocity.y = -2;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        move = camera.transform.right * x + camera.transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            velocity.y = Mathf.Sqrt(jumpHeight*-2f*gravity);
        }
        velocity.y += gravity * Time.deltaTime;  //vaihda kertomerkki plussaksi

        controller.Move(velocity * Time.deltaTime);

    }


}
