using UnityEngine;

public class PointSpawnGizmas : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 1f);
    }
}
