using UnityEngine;

public class InstantLookAtBehaviour : LookAtBehaviour
{
    void Awake(){

        behaviour = (entity) => {
            
            UnityEngine.Vector3 direcao = entity.GetAimFeatures().Target.position - entity.GetPosition();
            direcao.z = 0;
            entity.SetRotation(Quaternion.LookRotation(Vector3.forward, direcao));
        } ;

        SetBehaviour(behaviour);
    }
}