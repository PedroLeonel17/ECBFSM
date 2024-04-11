using UnityEngine;

public class ColliderFeatures
{
    [SerializeField]
    public EntityCollider entityCollider;

    [SerializeField]
    private GameEntity entity;

    /*
    private IGameEntity Ientity;

    void Awake(){
        Ientity = (IGameEntity)entity;
        IDamageable damageable = (IDamageable)Ientity;
        entityCollider.CollisionAction(damageable.ColisionAction());
    }*/

}
