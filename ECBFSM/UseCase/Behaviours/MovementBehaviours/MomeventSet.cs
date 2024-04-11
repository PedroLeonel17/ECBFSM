using System;
using System.Collections.Generic;
using UnityEngine;

public enum MovementType
{
    Chase,
    Directional,
    Accelerating,
    Attraction,

}

public class MovementSet : MonoBehaviour
{
    private static MovementSet instance;
    public static MovementSet Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<MovementSet>();

                if (instance == null)
                {
                    GameObject obj = new GameObject(typeof(MovementSet).Name);
                    instance = obj.AddComponent<MovementSet>();
                }
            }
            return instance;
        }
    }
    public Dictionary<MovementType, MovementBehaviour> behaviours = new Dictionary<MovementType, MovementBehaviour>();
    
    void Awake(){

        if (instance == null)
        {
            instance = GetComponent<MovementSet>();
        }

        behaviours = new Dictionary<MovementType, MovementBehaviour>
        {
            { MovementType.Accelerating, new AcceleratingBehaviour().SetBehaviour() },
            { MovementType.Chase,        new ChaseBehaviour().SetBehaviour()        },
            { MovementType.Attraction,   new AttractionBehaviour().SetBehaviour()   },
            { MovementType.Directional,  new DirectionalBehaviour().SetBehaviour()  }
        };

    }

    public MovementBehaviour GetBehaviour(MovementType behaviourType){
        return behaviours[behaviourType];
    }
}