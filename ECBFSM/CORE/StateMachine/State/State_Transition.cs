using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class State_Transition
{
    public Func<bool> ExitCondition { get; set; }
    public State NextState { get; set; }
    public  Action ActivationFunction { get; set; }

    public State_Transition( Func<bool> exitCondition, State nextState,  Action activationFunction)
    {
        ExitCondition = exitCondition;
        NextState = nextState;
        ActivationFunction = activationFunction;
    }

    public State_Transition(Func<bool> exitCondition, State nextState)
    {
        ExitCondition = exitCondition;
        NextState = nextState;
        ActivationFunction = null;
    }
}