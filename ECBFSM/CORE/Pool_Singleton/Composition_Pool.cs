using System.Collections.Generic;
using UnityEngine;

public class Composition_Pool<C,E,F,I> : Basic_Pool where C : GameObjComposition<E, F, I>
                                                    where E : GameEntity
                                                    where F : GameFeatures
                                                    where I : IBaseFeatures
{

    protected override void Awake()
    {

        if(GetEntity())
            base.Awake();
        else
            Debug.Log("The object dont have a instance of a GameObjComposition");

    }

    protected GameObjComposition<E, F, I> GetEntity()
    {    
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj.GetComponent<GameObjComposition<E, F, I>>();
            }
        }
        return null;
    }
    
}