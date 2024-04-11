using UnityEngine;

public class Pivot : Stat<Vector3>
{

    public Pivot(Vector3 value) : base(value)
    {

    }
     public override UnityEngine.Vector3 Value{
        get{
            return base.Value;
        }
        set{
            CurrentValue = value;
        }
    }
}