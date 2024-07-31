using UnityEngine;
using UnityEngine.Events;

public class Player : Character, IDamage, IHeal
{
    public int health = 3;
    public int minHealth = 0;
    public int maxHealth = 3;
    [Space]
    public Item currentItem;
    [Space]
    public UnityEvent<int> OnUpdateHealth;
    public UnityEvent<int> OnUpdateScore;
    public UnityEvent<int> OnUpdateScoreHigh;

    private IInteract otherCharacter;

    private void Start()
    {
        //OnUpdateHealth?.Invoke(health);
    }

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
            currentItem.ExecuteMessage();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        otherCharacter = other.gameObject.GetComponent<IInteract>();        
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        otherCharacter = null;
    }

    #region interfaces

    public void Damage(int value)
    {
        health = Mathf.Clamp(health - value, minHealth, maxHealth);
        //OnUpdateHealth?.Invoke(health);
    }

    public void Heal(int value)
    {
        health = Mathf.Clamp(health + value, minHealth, maxHealth);
        //OnUpdateHealth?.Invoke(health);
    }

    #endregion
}
