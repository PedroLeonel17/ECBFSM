using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardFeature : MonoBehaviour
{ 

    [SerializeField]
    protected bool isRaw = true;
    [SerializeField]
    protected bool changeAxis;
    [SerializeField]
    protected bool invertAxis;

    [SerializeField]
    private Vector3 Axis;

    string horizontal = "Horizontal";
    string vertical = "Vertical";

    void Awake(){
        if(changeAxis)
            ChangeAxis();

        Axis.z = 0;
    }

    void Update(){

        if(isRaw){
            Axis.x = Input.GetAxisRaw(horizontal);
            Axis.y = Input.GetAxisRaw(vertical);
        }else{
            Axis.x = Input.GetAxis(horizontal);
            Axis.y = Input.GetAxis(vertical);
        }

        if(invertAxis){
            Axis.x *= -1;
            Axis.y  *= -1;
        }
    
    }

    public void ChangeAxis(){
        string aux = horizontal;
        horizontal = vertical;
        vertical = aux;
    }

    public Vector3 GetAxis(){
        return Axis;
    }

}