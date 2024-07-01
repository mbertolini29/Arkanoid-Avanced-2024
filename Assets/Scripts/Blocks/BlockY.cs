using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockY : Block
{
    private void Awake()
    {
        Color = "Yellow";
        CurrentHitCount = 0;
        AllHitCount = 1;
        Score = 50;
    }

    private void Start()
    {
        Debug.Log($"El color del bloque es: {Color}{CurrentHitCount}{AllHitCount}{Score}");
    }

    public override void Damage(int hitCount)
    {
        CurrentHitCount = hitCount;
        if (CurrentHitCount >= AllHitCount)
        {
            Debug.Log("fui golpeado.");
        }
    }

    protected override void Destroy()
    {
        //eliminar objeto.
        Debug.Log("se destruyo bloque");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //IDamage otherCharacter = other.GetComponent<IDamage>();

        //if (otherCharacter != null)
        //{
        //    otherCharacter.Damage(1);
        //}
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        IDamage otherCharacter = other.gameObject.GetComponent<IDamage>();

        if (otherCharacter != null)
        {
            otherCharacter.Damage(1);
        }
    }
}
