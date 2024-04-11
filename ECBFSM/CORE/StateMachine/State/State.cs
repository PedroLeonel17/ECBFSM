using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class State : IState
{

    public List<State_Transition> exitConditions;
    public List<Action> actions;
    
    public string Name{get; set;}

    public State(string name){
        this.Name = name;
        exitConditions = new();
        actions = new();
    }

    public State(){
        exitConditions = new();
        actions = new();
    }
    
    public IState NextState()
    {
        foreach(State_Transition stateTransition in exitConditions){
            if(stateTransition.ExitCondition()){
                if(stateTransition.ActivationFunction != null)
                    stateTransition.ActivationFunction();
                return stateTransition.NextState;
            }
        }
        return this;
    }

    public IState Update()
    {
        RunActions();
        return NextState();
    }

    public void RunActions(){
        foreach(Action action in actions){
            action();
        }
    }
}
