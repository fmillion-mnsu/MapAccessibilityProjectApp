using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        float two_pi = 6.28319F;
        System.Random rand = new System.Random();
        int distance = 5;
        float angle = two_pi * (float) rand.NextDouble();
        int speed = 100;
        int degreeOfError = 1;


        float error = (float) (degreeOfError * rand.NextDouble()) - (degreeOfError / 2);

        Vector3 initialPosition = new Vector3(distance * Mathf.Sin(angle), 1, distance * Mathf.Cos(angle));
        transform.position = initialPosition;

        Vector3 initialVelocity = new Vector3(speed * Mathf.Sin(two_pi - angle + error), 0, speed * Mathf.Cos(two_pi - angle + error));
        // GetComponent<Rigidbody>().AddForce(initialVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Called once per 50th of a second or something like that
    void FixedUpdate()
    {
        
    }
}
