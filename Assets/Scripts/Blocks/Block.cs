using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    //Propiedades
    protected string Color { get; set; } //o material: e]
    protected int CurrentHitCount { get; set; }
    protected int AllHitCount { get; set; }
    protected int Score { get; set; }

    //Metodos
    protected abstract void TakeDamage(int hitCount);
    protected abstract void Destroy();
}
