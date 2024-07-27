using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWeapon : Item
{
    public override void ExecuteMessage()
    {
        Debug.Log($"{itemName}: shoot!");
    }
}
