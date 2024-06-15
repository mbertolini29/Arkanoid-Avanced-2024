using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    //plantilla de objetos base.
    [SerializeField] private string color;
    [SerializeField] protected int score;
    [SerializeField] protected int hitCount;

    //propiedad
    public string Color
    {
        get { return color; }
        set
        {
            color = value;
        }
    }

    private void Start()
    {
        AddHitCount();
    }

    public virtual void AddHitCount()
    {
        Debug.Log($"Cantidad de golpes: {hitCount}");
    }

    public abstract void DefineColor();

    //

    public virtual void Score()
    {
        Debug.Log($"mi puntaje es: {score}");
    }

    public virtual void TakeHit()
    {
        Debug.Log($"Falta {hitCount}");
    }

    public virtual void Destroy()
    {
        Debug.Log($"Me destruyo en: {hitCount}");
    }

    
}
