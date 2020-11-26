using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] private float thrust = 10f;
    [SerializeField] private Rigidbody rb;

    private Vector2 lastPos;
    public float startingThrust = 500f;
    

    void FixedUpdate()
    {
        

        Vector2 delta = Vector2.zero;

        if (Input.GetMouseButton(0))
        {
            Vector2 current = Input.mousePosition;

            if (lastPos == Vector2.zero)
                lastPos = current;

            delta = current - lastPos;
            lastPos = current;
            rb.AddForce(delta.x * thrust, 0 ,0);
        }
        else
        {
            lastPos = Vector2.zero;
        }
        rb.AddForce(0, 0, startingThrust * Time.deltaTime);
    }

}
