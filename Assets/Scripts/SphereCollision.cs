using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{

    public GameObject player;
    private GameObject self;
    private Color playerColor;

    private void OnCollisionEnter(Collision collision)
    {
        playerColor = player.GetComponent<Renderer>().material.color;

        self = collision.collider.gameObject;

        if(playerColor == collision.collider.GetComponent<Renderer> ().material.color)
        {
            self.AddComponent<Shatter>();

            StartCoroutine(self.GetComponent<Shatter>().SplitMesh(true));
        }
    }

}
