using UnityEngine;

public class GhostController : MonoBehaviour, IControllerBotAndGhostBehavior
{
    private ListLineTrigger _listLineTrigger;

    [SerializeField]
    private float _speedGhost;
    [SerializeField]
    private float _speedRotation;

    private int _indexPoint = 0;

    private string _controllerPoint = "ControllerPoint";

    private void Start()
    {
        _listLineTrigger =
       GameObject.Find(_controllerPoint).
       GetComponent<ListLineTrigger>();
        if (_listLineTrigger == null)
        {
            Debug.Log("Object control absent. Bot behavior = null");
        }
    }

    public void MoveWithPoint()
    {
        transform.position = Vector3.MoveTowards
            (transform.position,
            _listLineTrigger.GetTransformObject(_indexPoint),
            _speedGhost * Time.deltaTime);

        transform.rotation = Quaternion.Slerp(transform.rotation,
            Quaternion.LookRotation(_listLineTrigger.GetTransformObject(_indexPoint) - transform.position),
            _speedRotation * Time.deltaTime);

        if (Vector3.Distance(transform.position, _listLineTrigger.GetTransformObject(_indexPoint)) <= 0.2f)
        {
            _indexPoint++;
        }
    }
}
