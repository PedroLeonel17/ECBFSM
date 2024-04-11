using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour
{
    protected delegate void newBehaviour(IBaseFeatures mobileObj);
    protected newBehaviour actualBehaviour;

    public virtual MovementBehaviour SetBehaviour()
    {
        return this;
    }

    public void RunBehaviour(IBaseFeatures mobileObj){
        actualBehaviour(mobileObj);
    }

}