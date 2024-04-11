using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameFeatures : MonoBehaviour
{
    public MagnitudeOfMotion MagnitudeOfMotion;
    public Pivot CurrentVelocity;
    public FloatStat MaxSpeed;
}