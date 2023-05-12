using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    /*Declare a new private float speed variable
If using physics, declare a new Rigidbody playerRb variable for it and initialize it in Start()
If using arrow keys, declare new verticalInput and/or horizontalInput variables 
If basing your movement off a key press, create the if-statement to test for the KeyCode
Use either the Translate method or AddForce method (if using physics) to move your character*/

    public float speed;
    public float turnSpeed;
    public float xMoveInput;
    private float yMoveInput;

    public GameObject projectilePrefab;

    private Rigidbody rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, gameObject.transform.rotation);
        }
    }

    void FixedUpdate()
    {
        xMoveInput = Input.GetAxisRaw("Horizontal");
        yMoveInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.forward * (Time.deltaTime * speed * yMoveInput));
        if (xMoveInput != 0)
        {
            transform.Rotate(Vector3.up, (Time.deltaTime * turnSpeed * xMoveInput));

        }
    }
}
