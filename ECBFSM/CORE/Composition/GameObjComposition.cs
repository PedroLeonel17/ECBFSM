using UnityEngine;

public class GameObjComposition<E, F, I> : MonoBehaviour where E : GameEntity 
                                                                  where F : GameFeatures 
                                                                  where I : IBaseFeatures
{

    [SerializeField]
    protected E gameEntity;

    [SerializeField]
    protected StateMachine<I> stateMachine;

    [SerializeField]
    protected F features;

    public E GetEntity(){
        return gameEntity;
    }

    public F GetFeatures(){
        return features;
    }

    public StateMachine<I> StateMachine(){
        return stateMachine;
    }

}