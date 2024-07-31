using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Block : MonoBehaviour, IDamage
{
    public BlockSO data;

    //protected int currentHitCount;

    protected string Color { get; set; } //o material: ]
    public Vector2 Position { get; set; }    
    protected int CurrentHitCount { get; set; }
    protected int AllHitCount { get; set; }
    
    protected int Points { get; set; }

    [Space]
    public UnityEvent<int> OnUpdateScore;
    public UnityEvent<int> OnUpdateScoreHigh;

    public virtual void Damage(int value)
    {
        Debug.Log("choque block");
    }

    public virtual void OnCollisionEnter2D(Collision2D other)
    {
        IDamage otherCharacter = other.gameObject.GetComponent<IDamage>();

        if (otherCharacter != null)
        {
            otherCharacter.Damage(1);
        }
    }
}
