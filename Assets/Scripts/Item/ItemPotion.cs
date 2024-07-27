using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPotion : Item
{
    public override void ExecuteMessage()
    {
        Debug.Log($"{itemName}: drink!");
    }
}
