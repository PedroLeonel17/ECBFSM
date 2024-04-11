using System;
using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    [Range(-1f,1f)][SerializeField] float ParallaxSpeed; 

    public float GetSpeed(){
        return ParallaxSpeed;
    }
}