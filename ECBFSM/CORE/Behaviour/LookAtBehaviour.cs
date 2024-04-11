using System;
using UnityEngine;

public abstract class LookAtBehaviour : MonoBehaviour
{
    
    protected delegate void newBehaviour(ILookAtFeatures features);
    protected newBehaviour behaviour;

    protected void SetBehaviour(newBehaviour newBehaviour)
    {
        behaviour = newBehaviour;
    }

    public void RunBehaviour(ILookAtFeatures features)
    {
        behaviour(features);
    }
}