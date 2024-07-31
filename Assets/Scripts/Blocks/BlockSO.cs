using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlockSO", menuName = "SO/Block")]
public class BlockSO : ScriptableObject
{
    public Color color;
    public string nameBlock;
    public int HitCount;
    public int Score;
}
