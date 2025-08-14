using UnityEngine;

public class CheckTouchPoint : MonoBehaviour
{
    [SerializeField]
    private ProducePointWay _producePointWay;

    private void OnTriggerExit(Collider other)
    {
        _producePointWay.CreateObject(other.transform, other.transform.rotation);
    }
}
