using System;
using UnityEngine;

public class GunComposition : GameObjComposition<Gun, GunFeatures, IShootFeatures>, IShootFeatures
{
    
    SM_BUILDER<IBaseFeatures> builder;

    void Awake(){
        builder = GetComponent<SM_BUILDER<IBaseFeatures>>();

        ConfigStateMachine(builder);
    }

    void Update(){
        stateMachine.Run();
    }

    void ConfigStateMachine(SM_BUILDER<IBaseFeatures> builder){

        builder.CreateState();

        Action move = () => MovementSet.Instance.GetBehaviour(MovementType.Attraction);

        builder.SetAction(move);

    }

    public ShootFeatures GetShootFeatures()
    {
        return features.shootFeature;
    }

    public AimFeatures GetAimFeatures()
    {
        return features.aimFeature;
    }

    public Vector3 GetMovementPivot()
    {
        return features.targetFeature.Target.position;
    }

    public float GetMaxSpeed()
    {
       return features.MaxSpeed.Value;
    }

    public void AddVectorVelocity(Vector3 vector3)
    {
        features.CurrentVelocity.Value += vector3;
    }

    public void SetVectorVelocity(Vector3 vector3)
    {
        features.CurrentVelocity.Value = vector3;
    }

    public Vector3 GetVectorVelocity()
    {
        return features.CurrentVelocity.Value;
    }

    public float GetAcceleration()
    {
        return features.MagnitudeOfMotion.Value;
    }

    public float GetSpeed()
    {
        return features.MagnitudeOfMotion.Value;
    }

    public Vector3 GetPosition()
    {
        return GetEntity().GetPosition();
    }

    public void SetPosition(Vector3 position)
    {
        GetEntity().SetPosition(position);
    }

    public void AddPosition(Vector3 position)
    {
        GetEntity().AddPosition(position);
    }

    public void GetRotation()
    {
        throw new NotImplementedException();
    }

    public void AddRotation(Quaternion rotation)
    {
        throw new NotImplementedException();
    }

    public void SetRotation(Quaternion position)
    {
        throw new NotImplementedException();
    }
}