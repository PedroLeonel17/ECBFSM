using Unity.Mathematics;

public class Healing : FloatStat, ILifeModifier
{
    public Healing(float value, float min, float max) : base(value, min, max)
    {
        
    }

    public float Apply(Health health)
    {
        health.Value += Value; 
        return Value;
    }
}