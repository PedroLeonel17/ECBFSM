using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DirectionalBehaviour : MovementBehaviour
{
    Vector3 direction;
    float velocity;

    public override MovementBehaviour SetBehaviour(){

        base.actualBehaviour = (features) => {

            direction = features.GetMovementPivot().normalized;
            velocity = features.GetSpeed();
    
            features.SetVectorVelocity(direction * (Time.deltaTime * velocity));
            
            features.AddPosition(features.GetVectorVelocity());

        } ;
        
        return this;
    }

}
