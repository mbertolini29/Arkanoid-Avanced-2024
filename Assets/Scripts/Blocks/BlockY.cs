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

    protected override void TakeDamage(int hitCount)
    {
        CurrentHitCount = hitCount;
        if (CurrentHitCount >= AllHitCount) Destroy();
    }

    protected override void Destroy()
    {
        //eliminar objeto.
        Debug.Log("se destruyo bloque");
    }
}
