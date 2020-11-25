using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform sphereLoc;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = sphereLoc.position + offset;
    }
}
