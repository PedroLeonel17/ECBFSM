using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class SM_BUILDER<I> where I : IBaseFeatures
{

    State InitialState;
    State ActualState{get;set;}

    public SM_BUILDER<I> CreateState(){

        if(InitialState == null){
            InitialState = new State();
            ActualState = InitialState;
            Debug.Log("Criou o primeiro estado");
        }else
            ActualState = new State();

        return this;
    }

    public SM_BUILDER<I> SetActions(List<Action> actions){
        ActualState.actions = (actions);
        return this;
    }

    public SM_BUILDER<I> SetAction(Action action){
        ActualState.actions.Add(action);
        return this;
    }


    public State GetCurrentState(){
        return ActualState;
    }

    public State GetInitialState(){
        return InitialState;
    }
}
