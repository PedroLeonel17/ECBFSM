using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                if (instance == null)
                {
                    GameObject obj = new GameObject(typeof(GameManager).Name);
                    instance = obj.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    [SerializeField]
    private Transform player;

    void Awake()
    {
        if (instance == null)
        {
            instance = GetComponent<GameManager>();
        }
    }

    public Vector2 GetPlayerPosition(){
        return player.position;
    }
    
}