using UnityEngine;

public class Controller : MonoBehaviour
{
    private IControllable _controllable;

    private void Start()
    {
        _controllable = GetComponent<IControllable>();
        BoolStartButton.Instance = false;
    }

    private void FixedUpdate()
    {
        if (BoolStartButton.Instance == true)
        {
            _controllable.MoveController();
            _controllable.RotateController();
            _controllable.GravityController();
        }
    }
}

