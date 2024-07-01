using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboard : InputHandler
{
    public override float GetAxisHorizontal()
    {
        return Input.GetAxis("Horizontal");
    }
}
