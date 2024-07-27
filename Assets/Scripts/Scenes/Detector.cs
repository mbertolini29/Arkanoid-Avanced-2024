using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Character otherCharacter = other.GetComponent<Character>();

        if(otherCharacter != null)
        {
            Debug.Log($"Name: {otherCharacter.characterName}");
        }
    }
}
