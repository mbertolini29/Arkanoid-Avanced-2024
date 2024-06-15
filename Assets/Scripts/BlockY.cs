using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockY : Block
{
    private void Start()
    {
        DefineColor();
    }
    public override void DefineColor()
    {
        Color = "Yellow";
        Debug.Log($"El color del bloque es: {Color}");
    }

    public override void AddHitCount()
    {
        base.AddHitCount();

        hitCount = 5;
        Debug.Log($"Golpes necesarios: {hitCount}");
    }
}
