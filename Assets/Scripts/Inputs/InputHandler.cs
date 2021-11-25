using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface InputHandler
{
    void ProcessInput(Vector3 inputPosition, GameObject selectedObject, Action callback);
}
