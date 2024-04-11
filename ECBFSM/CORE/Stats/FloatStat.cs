using System;

public class FloatStat : NumStat<float>
{

    public FloatStat(float v, float min, float max) : base(v,  min,  max){
      
    }

    public override float Value{
        get{
            return base.Value;
        }
        set{
            CurrentValue = Math.Clamp(value,minValue,maxValue);
        }
    }
}