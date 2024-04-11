using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stat<T> : MonoBehaviour
{
   [SerializeField]protected T CurrentValue;

    public Stat(T v){
        Value = v;
    }

    public virtual T Value{
        get{
            return CurrentValue;
        }
        set{
            
            CurrentValue = value;
        }
    }
}
