using System;
using UnityEngine;

public class PlayerComposition : GameObjComposition<Player, PlayerFeatures, IBaseFeatures>, IBaseFeatures
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

        MovementBehaviour accelerating  =   MovementSet.Instance.
                                            GetBehaviour(MovementType.Accelerating);

        Action move  = () => accelerating.RunBehaviour(this);
    
        State Shooting   = builder.CreateState().SetAction(move).GetCurrentState();
       
    }

    public Vector3 GetMovementPivot()
    {
        return features.KeyBoardFeature.GetAxis();
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
        return features.CurrentVelocity.Value.magnitude;
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
        gameEntity.GetRotation();
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
