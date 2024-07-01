using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour, IDamage
{
    //Propiedades
    protected string Color { get; set; } //o material: ]
    public Vector2 Position { get; set; }
    
    protected int CurrentHitCount { get; set; }
    protected int AllHitCount { get; set; }
    
    protected int Score { get; set; }

    //Metodos
    //protected abstract void TakeDamage(int hitCount);

    protected abstract void Destroy();

    public virtual void Damage(int value)
    {
        throw new System.NotImplementedException();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    IDamage otherCharacter = other.GetComponent<IDamage>();

    //    if(otherCharacter != null)
    //    {
    //        otherCharacter.Damage(1);
    //    }
    //}
}
