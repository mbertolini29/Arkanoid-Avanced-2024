using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse : InputHandler
{
    public float sensitivity = 1;

    public override float GetAxisHorizontal()
    {
        return Input.GetAxis("Mouse X") * sensitivity;
    }
}
