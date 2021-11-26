using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IInputHandler
{
    void ProcessInput(Vector3 inputPosition, GameObject selectedObject, Action callback);
}
