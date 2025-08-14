using UnityEngine;

public class GhostResource : MonoBehaviour
{
    [SerializeField]
    private GhostController _ghostController;

    private void FixedUpdate()
    {
        _ghostController.MoveWithPoint();
    }
}
