using System;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyComposition: GameObjComposition<Enemy, EnemyFeatures, IBaseFeatures>, IBaseFeatures
{
    
    void Start(){
        BasicBuilder builder = new BasicBuilder();

        ConfigStateMachineBuilder(builder);

        stateMachine.Initialize(builder);
    }

    void Update(){
        stateMachine.Run();
    }

    void ConfigStateMachineBuilder(BasicBuilder builder){

        MovementBehaviour movement = MovementSet.Instance.GetBehaviour(MovementType.Chase);

        movement.SetBehaviour();

        builder .CreateState()
                .SetAction(() => movement.RunBehaviour(this));
    
    }

    public Vector3 GetMovementPivot()
    {
        return features.pivotFeature.Target.position;
    }

    public float GetMaxSpeed()
    {
        return features.MaxSpeed.Value;
    }

    public Vector3 GetVectorVelocity()
    {
        return features.CurrentVelocity.Value;
    }

    public float GetAcceleration()
    {
        return features.MagnitudeOfMotion.Value;
    }

    public void AddVectorVelocity(Vector3 vector3)
    {
        features.CurrentVelocity.Value += vector3;
    }

    public void SetVectorVelocity(Vector3 vector3)
    {
        features.CurrentVelocity.Value = vector3;
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