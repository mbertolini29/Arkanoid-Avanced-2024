using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour, IInteract
{
    public Item currentItem;
    
    private IInteract otherCharacter;

    public void ActionInteraction()
    {
        if(otherCharacter != null)
        {
            otherCharacter.Interact();
        }
    }

    public void ActionConsumeItem()
    {
        if(currentItem != null)
        {
            if(currentItem is ItemWeapon)
            {
                Debug.Log($"{currentItem.itemName}: shoot!");
            }
            else if(currentItem is ItemPotion)
            {
                Debug.Log($"{currentItem.itemName}: drink!");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        otherCharacter = other.GetComponent<IInteract>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        otherCharacter = null;
    }

    #region interfaces

    public void Interact()
    {
        //throw new System.NotImplementedException();

        Debug.Log("toque pelota");
    }

    #endregion
}
