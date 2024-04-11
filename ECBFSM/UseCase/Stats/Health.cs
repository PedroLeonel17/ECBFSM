using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : FloatStat
{
    public bool isEmpty{ get { return Value <= 0;} }

    public Health(float value, float min, float max) : base(value, min, max)
    {

    }
}
