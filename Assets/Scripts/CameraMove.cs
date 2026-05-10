using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    void Start()
    {
    }

    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
