using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_Pool : Composition_Pool<EnemyComposition, Enemy, EnemyFeatures, IBaseFeatures>
{
    public float Radius = 40f;
    public Player player;

    public List<GameObject> inimigosAtivos;
    protected override void Awake()
    {
        base.Awake();
        SpawnInimigos();
        //OrdenarPorDistancia();
    }

    void SpawnInimigos()
    {
        for (int i = 0; i < poolSize; i++)
        {
            Vector2 spawnPosition = Random.insideUnitCircle.normalized * Random.Range(10f, Radius);

            GameObject enemy = pool[i].GetComponent<EnemyComposition>().GetEntity().gameObject;

            if(enemy != null && !enemy.activeInHierarchy){
                enemy.SetActive(true);
                pool[i].GetComponent<EnemyComposition>().GetEntity().SetPosition(spawnPosition);
            }   
        }
    }
    
    float time = 0;
    void Update(){
       
        time += Time.deltaTime;

        if(time >=0.1){
            for (int i = 0; i < poolSize; i++)
            {
                Vector2 spawnPosition = Random.insideUnitCircle.normalized * Random.Range(10f, Radius);

                GameObject enemy = pool[i].GetComponent<EnemyComposition>().GetEntity().gameObject;

                if(enemy != null && !enemy.activeInHierarchy){
                    enemy.SetActive(true);
                    pool[i].GetComponent<EnemyComposition>().GetEntity().SetPosition(spawnPosition);
                    break;
                }
                
            }
            time = 0;
        }

    }

    public Enemy GetFirst(){
        if(inimigosAtivos.Count() > 0)
            return inimigosAtivos[0].GetComponent<Enemy>();
        return null;
    }

    
    public List<GameObject> OrdenarPorDistancia(Vector3 myPosition)
    {
        List<Enemy> activeEnemies = pool.FindAll(enemy => enemy.GetComponent<EnemyComposition>().GetEntity().IsActive())
                                         .ConvertAll(enemyComposition => (Enemy)GetComponent<EnemyComposition>().GetEntity());

        activeEnemies.Sort((a, b) =>
        {

            float distanciaA = Vector3.Distance(a.GetPosition(), myPosition);
            float distanciaB = Vector3.Distance(b.GetPosition(), myPosition);

            return distanciaA.CompareTo(distanciaB);
        });

        return activeEnemies.ConvertAll(enemy => enemy.gameObject);
    }

}

 