using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ECBFSM_Actions{
    public static void Turn(Transform transform, UnityEngine.Vector3 direction){
        float dir = direction.x;

        if(Mathf.Abs(dir) > 0f){
            int sense = (int)(dir/Mathf.Abs(dir));
            float x = sense * Mathf.Abs(transform.localScale.x);
            UnityEngine.Vector3 turnedScale = new(x, transform.localScale.y,1);
            transform.localScale = turnedScale;
        }
    }

    public static void TookDamage(Health health, Damage damage){
        health.Value -= damage.Value;
    }

    public static void LookAt(UnityEngine.Vector3 observerPosition, UnityEngine.Vector3 targetPosition){
      
    }


    
    public static void SpawnObject(IBaseFeatures gameObject, Transform muzzle){
        gameObject.SetPosition(muzzle.position);
        gameObject.SetRotation(muzzle.rotation);
    }

    public static Quaternion AdjustAngle(Transform myTransform, Transform targetAngle){
        Vector2 direction =  targetAngle.position - myTransform.transform.position;
        
        direction.Normalize();

        float angulo = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       
        return Quaternion.Euler(0f, 0f, angulo+90);
    }

}
