using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Damage : FloatStat, ILifeModifier
{
    public Damage(float value, float min, float max) : base(value, min, max)
    {
        
    }

    public float Apply(Health health)
    {
        health.Value -= Value; 
        return Value;
    }
    
}
