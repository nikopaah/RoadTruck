using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    [SerializeField]
    private float speed = 15f;
    [SerializeField]
    private float turnSpeed = 5f;
    [SerializeField]
    private float xInput, yInput;


    // Update is called once per frame
    void Update()
    {
        // Get player input
        xInput = Input.GetAxis("Horizontal-P1");
        yInput = Input.GetAxis("Vertical-P1");


        // Moves the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * yInput);
        //                         (0, 0, 1)

        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * xInput);
    }
}
