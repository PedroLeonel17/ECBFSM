
using System.Collections.Generic;
using UnityEngine;

public class Basic_Pool : MonoBehaviour
{
    
    public GameObject gObject;
    public int poolSize = 10;
    public List<GameObject> pool;
    private static MonoBehaviour instance;

    public static MonoBehaviour Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<MonoBehaviour>();

                if (instance == null)
                {
                    GameObject obj = new GameObject(typeof(MonoBehaviour).Name);
                    instance = obj.AddComponent<MonoBehaviour>();
                }
            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as MonoBehaviour;
        }
        else
        {
            Destroy(gObject);
        }

        InitializePool();
    }

    void InitializePool()
    {
        pool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(gObject);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

}
