using UnityEngine;

[CreateAssetMenu(fileName = "CameraConfig", menuName = "Scriptable Objects/CameraConfig")]
public class CameraConfig : ScriptableObject
{
    public float turnSmooht;
    public float pivotSpeed;
    public float YRotationSpeed;
    public float XRotationSpeed;
    public float minAngel;
    public float maxAngel;
    public float normalX;
    public float normalZ;
    public float aimZ;
    public float aimX;
    public float normalY;
}
