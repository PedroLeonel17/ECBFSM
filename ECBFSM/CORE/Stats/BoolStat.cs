using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolStat : Stat<bool>
{
    public BoolStat(bool value ) : base(value){
      
    }

    public override bool Value{
        get{
            return base.Value;
        }
        set{
            CurrentValue = value;
        }
    }
}
