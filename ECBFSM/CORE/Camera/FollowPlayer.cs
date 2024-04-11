
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
        Vector2 playerPosition = GameManager.Instance.GetPlayerPosition();

        //if((playerPosition - (Vector2)Camera.main.transform.position).magnitude > 4f){
            Vector2 vec = Vector3.Lerp(Camera.main.transform.position, playerPosition, 2f * Time.deltaTime) ;
            transform.position = new Vector3(vec.x, vec.y,-10);
        //}
       
    }
}
