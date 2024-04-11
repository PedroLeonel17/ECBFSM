using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AcceleratingBehaviour : MovementBehaviour
{

    public override MovementBehaviour SetBehaviour(){
        
         base.actualBehaviour = (features) => {

            Vector3 direction  = features.GetMovementPivot();
            float acceleration = features.GetAcceleration();
          

            features.AddVectorVelocity(direction * ( acceleration * Time.deltaTime ));
            
            if(features.GetSpeed() >= features.GetMaxSpeed())
                features.SetVectorVelocity(features.GetVectorVelocity().normalized * features.GetMaxSpeed());
            
            features.AddPosition(features.GetVectorVelocity() * Time.deltaTime);
            
        } ;

        return this;
    }
    
}