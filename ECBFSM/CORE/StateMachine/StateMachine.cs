using System;
using UnityEngine;
using System.Collections;

public abstract class StateMachine<I> : MonoBehaviour where I : IBaseFeatures
{

    State InitialState;

    public IState CurrentState;

    public virtual void Initialize(SM_BUILDER<I> builder){
        InitialState = builder.GetInitialState();
        ResetState();
    }

    public virtual void ResetState(){
        CurrentState = InitialState;
    }

    public virtual void Run(){
        CurrentState = CurrentState.Update();
    }

}
