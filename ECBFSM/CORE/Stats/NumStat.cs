using System;
using UnityEngine;

public abstract class NumStat<T> : Stat<T>
{
    [Range(-100f, 100f)][SerializeField] protected T maxValue;
    [Range(-100f, 100f)][SerializeField] protected  T minValue;

    public NumStat(T v, T min, T max) :base(v){

        minValue = min;
        maxValue = max;
    }

     public override T Value{
        get{
            return base.Value;
        }
        set{
            CurrentValue = value;
        }
    }

    public void SetMin(T min){
        minValue = min;
    }

    public void SetMax(T max){
        maxValue = max;
    }
}
