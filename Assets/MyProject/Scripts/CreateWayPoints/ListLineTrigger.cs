using System.Collections.Generic;
using UnityEngine;

public class ListLineTrigger : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _listPointWay;

    public void AddObject(GameObject gameObject)
    {
        _listPointWay.Add(gameObject);
    }

    public Vector3 GetTransformObject(int index)
    {
        if (_listPointWay.Count == 0)
        {
            Debug.Log("Лист пуст");
            return transform.position;
        }
        else
        {
            for (int i = 0; i < _listPointWay.Count; i++)
            {
                i = index;
                Debug.Log($"Bot position follow!!!!!!!!{_listPointWay[index].transform.position}!!!!!!!!!!!!!!!");

                if(index > _listPointWay.Count)
                {
                    index = 0; 
                }
                return _listPointWay[index].transform.position;
            }
        }
        return transform.position;
    }
}
