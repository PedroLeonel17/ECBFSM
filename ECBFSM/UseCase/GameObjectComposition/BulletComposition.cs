using Unity.VisualScripting;
using UnityEngine;

public class BulletComposition : GameObjComposition<BasicBullet, ProjectileFeatures, IBaseFeatures>, IBaseFeatures
{
    public void AddPosition(Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public void AddRotation(Quaternion rotation)
    {
        throw new System.NotImplementedException();
    }

    public void AddVectorVelocity(Vector3 vector3)
    {
        throw new System.NotImplementedException();
    }

    public float GetAcceleration()
    {
        throw new System.NotImplementedException();
    }

    public float GetMaxSpeed()
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetMovementPivot()
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetPosition()
    {
        throw new System.NotImplementedException();
    }

    public void GetRotation()
    {
        throw new System.NotImplementedException();
    }

    public float GetSpeed()
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetVectorVelocity()
    {
        throw new System.NotImplementedException();
    }

    public void SetPosition(Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public void SetRotation(Quaternion rotation)
    {
        gameEntity.SetRotation(rotation);
    }

    public void SetVectorVelocity(Vector3 vector3)
    {
        throw new System.NotImplementedException();
    }
}