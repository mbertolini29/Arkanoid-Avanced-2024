using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    public void UpdateHealth(int value)
    {
        healthText.text = $"{value}";
    }
}
