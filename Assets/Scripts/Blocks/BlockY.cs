using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockY : Block
{
    private void Awake()
    {
        //Color = "Yellow";
        CurrentHitCount = 0;
        AllHitCount = 1;
        Points = 50;
    }

    private void Start()
    {
        Debug.Log($"El color del bloque es: {Color}{CurrentHitCount}{AllHitCount}{Points}");
    }

    public override void Damage(int hitCount)
    {
        CurrentHitCount += hitCount;
        if (CurrentHitCount >= AllHitCount)
        {
            Destroy(this.gameObject);

            //
            OnUpdateScore?.Invoke(Points);
        }
    }

    private void OnDestroy()
    {
        //OnUpdateScore?.Invoke(Points);
    }

    public override void OnCollisionEnter2D(Collision2D other)
    {
        IDamage otherCharacter = other.gameObject.GetComponent<IDamage>();

        if (otherCharacter != null)
        {
            otherCharacter.Damage(1);
        }
    }
}
