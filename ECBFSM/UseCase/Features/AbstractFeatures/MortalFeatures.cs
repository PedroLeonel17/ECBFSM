using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MortalFeatures : MonoBehaviour
{
    public Health Health;

    public Health TookDamage(){
        return Health;
    }
}
