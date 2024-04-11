using UnityEngine;

public interface IBaseFeatures 
{
    
    public Vector3 GetMovementPivot();
    public float GetMaxSpeed();
    public void AddVectorVelocity(Vector3 vector3);
    public void SetVectorVelocity(Vector3 vector3);
    public Vector3 GetVectorVelocity();
    public float GetAcceleration();
    public float GetSpeed();
    public Vector3 GetPosition();
    public void SetPosition(Vector3 position);
    public void AddPosition(Vector3 position);
    public void GetRotation();
    public void AddRotation(Quaternion rotation);
    public void SetRotation(Quaternion position);

}