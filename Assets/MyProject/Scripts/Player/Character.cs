using UnityEngine;

public class Character : MonoBehaviour, IControllable
{
    [SerializeField]
    private float _speedPlayer;
    [SerializeField]
    private float _speedRotatePlayer;
    [SerializeField]
    private float _gravity;
    [SerializeField]
    private float _distanceGround;

    private string _horizontalMoveX = "Horizontal";
    private string _verticalMoveY = "Vertical";

    [SerializeField]
    private bool _isGrounded;

    [SerializeField]
    private CharacterController _characterController;
    [SerializeField]
    private Transform _playerBody;

    private Vector3 _velocity;

    [SerializeField]
    private Transform _groundCheck;

    [SerializeField]
    private LayerMask _groundMask;

    public void MoveController()
    {
        float moveY = Input.GetAxis(_verticalMoveY);

        Vector3 move = _playerBody.forward * moveY;
        _characterController.Move(move * _speedPlayer * Time.deltaTime);
    }

    public void GravityController()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _distanceGround, _groundMask);

        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }

        _velocity.y += _gravity * Time.deltaTime;

        _characterController.Move(_velocity * Time.deltaTime);
    }

    public void RotateController()
    {
        float moveX = Input.GetAxis(_horizontalMoveX);

        _characterController.transform.Rotate(Vector3.up * moveX * _speedRotatePlayer * Time.deltaTime);
    }
}

