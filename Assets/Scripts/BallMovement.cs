using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] private float thrust = 10f;
    [SerializeField] private Rigidbody rb;

    private Vector2 lastPos;
    public float startingThrust = 10f;

    void Start()
    {
        rb.velocity = transform.forward * startingThrust;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 delta = Vector2.zero;

        if (Input.GetMouseButton(0))
        {
            Vector2 current = Input.mousePosition;

            if (lastPos == Vector2.zero)
                lastPos = current;

            delta = current - lastPos;
            lastPos = current;

            Vector3 force = new Vector3(delta.x, 0, delta.y) * thrust;
            rb.AddForce(force);
        }
        else
        {
            lastPos = Vector2.zero;
        }
    }
}
