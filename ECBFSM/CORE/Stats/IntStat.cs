using System;

public abstract class IntStat : NumStat<int>
{

    public IntStat(int v, int min, int max) : base(v, min, max)
    {
        
    }

    public override int Value{
        get{
            return base.Value;
        }
        set{
            CurrentValue = Math.Clamp(value,minValue,maxValue);
        }
    }
}
