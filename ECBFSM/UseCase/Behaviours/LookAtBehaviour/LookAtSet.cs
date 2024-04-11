using System;
using System.Collections.Generic;
using UnityEngine;

public enum LookAtType
{
    Locked,
    Smooth

}

public class LookAtSet : MonoBehaviour
{

    private static LookAtSet instance;
    public static LookAtSet Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<LookAtSet>();

                if (instance == null)
                {
                    GameObject obj = new GameObject(typeof(LookAtSet).Name);
                    instance = obj.AddComponent<LookAtSet>();
                }
            }
            return instance;
        }
    }
    public Dictionary<LookAtType, LookAtBehaviour> behaviours = new Dictionary<LookAtType, LookAtBehaviour>();
    
    void Awake(){

        if (instance == null)
        {
            instance = GetComponent<LookAtSet>();
        }

        behaviours = new Dictionary<LookAtType, LookAtBehaviour>();

        behaviours.Add(LookAtType.Locked,   new InstantLookAtBehaviour()   );

    }

    public LookAtBehaviour GetBehaviour(LookAtType behaviourType){
        return behaviours[behaviourType];
    }
}