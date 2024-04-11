using System;
using System.Collections.Generic;
using System.Threading;
using Unity.Collections;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    [SerializeField]
    List<ParallaxLayer> layers;

    void Awake(){
        layers = new List<ParallaxLayer>();

        ParallaxLayer[] objetosParallax = GetComponentsInChildren<ParallaxLayer>();

        layers.AddRange(objetosParallax);
    }

    void Update()
    {
        foreach(ParallaxLayer layer in layers){

            UnityEngine.Vector3 direction = GameManager.Instance.GetPlayerPosition() - (Vector2)Camera.main.transform.position;

            UnityEngine.Vector3 vec = direction.normalized * direction.magnitude  * (layer.GetSpeed() * 2f * Time.deltaTime);
            
            layer.transform.position += (vec);
    
        }
    }
}