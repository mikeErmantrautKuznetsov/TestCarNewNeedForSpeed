using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private ICameraController _controller;

    private void Start()
    {
        _controller = GetComponent<ICameraController>();
    }

    private void FixedUpdate()
    {
        _controller.CameraRotation();
    }
}
