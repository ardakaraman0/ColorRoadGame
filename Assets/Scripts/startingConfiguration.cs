using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class startingConfiguration : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        Color[] colors = { new Color(1,0,0,1), new Color(0, 1, 0, 1), new Color(0, 0, 1, 1) };
        GetComponent<Renderer>().material.color = colors[Random.Range(0,2)];
        
    }

}
