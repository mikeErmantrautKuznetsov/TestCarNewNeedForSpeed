using UnityEngine;
using Zenject;

public class CameraController : MonoBehaviour, ICameraController
{
    [SerializeField]
    private Transform _camTransform;
    [SerializeField]
    private Transform _pivot;
    [SerializeField]
    private Character _character;
    [SerializeField]
    private Transform _mTransform;

    [SerializeField]
    private CameraConfig _cameraConfig;

    [SerializeField]
    private bool _leftPivot;

    [SerializeField]
    private float _delta;
    [SerializeField]
    private float _mouseScriptableX;
    [SerializeField]
    private float _mouseScriptableY;
    [SerializeField]
    private float _smoothX;
    [SerializeField]
    private float _smoothY;
    [SerializeField]
    private float _smoothXVelocity;
    [SerializeField]
    private float _smoothYVelocity;
    [SerializeField]
    private float _lookAngle;
    [SerializeField]
    private float _titelAngle;

    private const string _mouseX = "Mouse X";
    private const string _mouseY = "Mouse Y";

    [Inject]
    public void Construct(Character character)
    {
        _character = character;
    }

    public void CameraRotation()
    {
        FixedTick();
    }

    private void FixedTick()
    {
        _delta = Time.deltaTime;

        HandlePosition();
        HandleRotation();

        Vector3 targetPosition = Vector3.Lerp(_mTransform.position, _character.transform.position, 1);
        _mTransform.position = targetPosition;
    }

    private void HandlePosition()
    {
        float targetX = _cameraConfig.normalX;
        float targetY = _cameraConfig.normalY;
        float targetZ = _cameraConfig.normalZ;

        if (_leftPivot)
        {
            targetX = -targetX;
        }

        Vector3 newPivotPosition = _pivot.localPosition;
        newPivotPosition.x = targetX;
        newPivotPosition.y = targetY;

        Vector3 newCameraPosition = _camTransform.localPosition;
        newCameraPosition.z = targetZ;

        float t = _delta * _cameraConfig.pivotSpeed;
        _pivot.localPosition = Vector3.Lerp(_pivot.localPosition, newPivotPosition, t);
        _camTransform.localPosition = Vector3.Lerp(_camTransform.localPosition, newCameraPosition, t);
    }

    private void HandleRotation()
    {
        float mouseX = Input.GetAxis(_mouseX);
        float mouseY = Input.GetAxis(_mouseY);

        if (_cameraConfig.turnSmooht > 0)
        {
            _smoothX = Mathf.SmoothDamp(_smoothX, mouseX, ref _smoothXVelocity, _cameraConfig.turnSmooht);
            _smoothY = Mathf.SmoothDamp(_smoothY, mouseY, ref _smoothYVelocity, _cameraConfig.turnSmooht);
        }
        else
        {
            _smoothX = mouseX;
            _smoothY = mouseY;
        }

        _lookAngle += _smoothX * _cameraConfig.YRotationSpeed;
        Quaternion targetRot = Quaternion.Euler(0, _lookAngle, 0);
        _mTransform.rotation = targetRot;

        _titelAngle -= _smoothY * _cameraConfig.YRotationSpeed;
        _titelAngle = Mathf.Clamp(_titelAngle, _cameraConfig.minAngel, _cameraConfig.maxAngel);
        _pivot.localRotation = Quaternion.Euler(_titelAngle, 0, 0);
    }
}