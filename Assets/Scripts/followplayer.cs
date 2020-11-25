using UnityEngine;

public class followplayer : MonoBehaviour
{

    public Transform playerLoc;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = playerLoc.position + offset;
    }
}
