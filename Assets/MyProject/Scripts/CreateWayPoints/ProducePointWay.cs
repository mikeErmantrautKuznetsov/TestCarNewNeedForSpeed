using UnityEngine;

public class ProducePointWay : MonoBehaviour
{
    [SerializeField]
    private GameObject _point;
    [SerializeField]
    private ListLineTrigger _botListGoals;

    public void CreateObject(Transform pointCreate, Quaternion rotate)
    {
        GameObject pointWay = Instantiate(_point, pointCreate.position, 
            rotate);
        _botListGoals.AddObject(pointWay);
    }
}
