using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseBehaviour : MovementBehaviour
{

    public override MovementBehaviour SetBehaviour(){

        base.actualBehaviour = (features) => {

            Vector3 direction = (features.GetMovementPivot() - features.GetPosition()).normalized;
            float speed = features.GetSpeed();
            
            features.AddPosition(direction * (Time.deltaTime * speed));

        } ;

        return this;
    }

}
