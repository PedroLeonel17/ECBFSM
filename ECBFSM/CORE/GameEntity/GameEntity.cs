using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameEntity : MonoBehaviour
{

    public Vector3 GetPosition(){
        return transform.position;
    }
    public void SetPosition(Vector3 vector3){
        transform.position = vector3;
    }

    public void AddPosition(Vector3 vector3){
        transform.position += vector3;
    }

    public Quaternion GetRotation(){
        return transform.rotation;
    }

    public void SetRotation(Quaternion quaternion){
        transform.rotation = quaternion;
    }

    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public bool IsActive()
    {
        return gameObject.activeInHierarchy;
    }

}
