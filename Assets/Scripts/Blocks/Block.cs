using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour, IDamage
{
    public BlockSO data;

    private int currentHitCount;
    private Vector2 position;

    [Space]
    public UnityEvent<int> OnUpdateScore;
    public UnityEvent<int> OnUpdateScoreHigh;

    private void Awake()
    {
        InitializeBlock();
    }

    private void InitializeBlock()
    {
        currentHitCount = 0;
        GetComponent<SpriteRenderer>().color = data.color;
    }

    public void Damage(int value)
    {
        currentHitCount += value;
        if (currentHitCount >= data.hitCount)
        {
            DestroyBlock();
        }
    }

    private void DestroyBlock()
    {
        OnUpdateScore?.Invoke(data.score);
        Destroy(gameObject);
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
