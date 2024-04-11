using System;
using UnityEngine;

public class AttractionBehaviour: MovementBehaviour
{   
    Vector3 destiny;
    float velocity;
    Vector3 currentPosition;

    public override MovementBehaviour SetBehaviour(){

        base.actualBehaviour = (features) => {

            destiny  = features.GetMovementPivot();
            velocity = features.GetSpeed();
            currentPosition = features.GetPosition();

            features.SetVectorVelocity(Vector3.Lerp(currentPosition, destiny, Time.deltaTime * velocity));
            
            features.SetPosition(features.GetVectorVelocity());

        } ;

        return this;
    }

}
