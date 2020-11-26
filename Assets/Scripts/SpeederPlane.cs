using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeederPlane : MonoBehaviour
{
    public Rigidbody player;
    public float force = 100f;

    private void OnTriggerExit(Collider other)
    {
        player.AddForce(0, force/10, force);
    }

}
