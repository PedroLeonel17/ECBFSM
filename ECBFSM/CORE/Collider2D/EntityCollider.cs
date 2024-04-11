using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EntityCollider : MonoBehaviour, ICollider
{

    [SerializeField] private string colisorTag;

    private ICollider.VerifyColision Collider;

    public void CollisionAction(ICollider.VerifyColision colision)
    {
        Collider = colision;
    }

    void OnTriggerEnter2D (Collider2D other){
        if(other.CompareTag(colisorTag)){
            try
            {
                // Código que pode lançar uma exceção
                EntityCollider entityCollider = other.GetComponent<EntityCollider>();
                
                if (entityCollider == null)
                {
                    // Lançar uma exceção personalizada, se necessário
                    throw new System.Exception("Objeto que colidiu não tem um EntityCollider.");
                }
                Collider.Invoke(entityCollider);
            }
            catch (System.Exception ex)
            {
                // Lidar com a exceção
                Debug.LogError("Exceção: " + ex.Message);
            }
        }
    }
}