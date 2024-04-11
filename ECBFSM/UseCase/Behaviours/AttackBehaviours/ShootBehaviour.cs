using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class ShootBehaviour : MonoBehaviour
{
    /*
    public static IEnumerator DoAction(IShootFeatures features){
        
        ShootFeatures shootFeatures= features.GetShootFeatures();
        shootFeatures.IsShooting = true;
        
        //shootFeatures.ShootBehaviour.PlaySound();
        
        BasicBullet bf = Bullet_Pool.Instance.GetEntity();

        bf.SetTarget(features.Gun.GetTarget());
        
        ECBFSM_Actions.SpawnObject(bf, features.Gun.ShootBehaviour.GetMuzzle());
        
        yield return new WaitForSeconds(1.0f/features.Gun.ShootBehaviour.GetRPS());

        features.GetShootFeatures().IsShooting = true;
    }*/
}

  