using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputReceiver : MonoBehaviour
{
    protected InputHandler[] inputHandlers;

    public abstract void OnInputReceived();

    private void Awake()
    {
        inputHandlers = GetComponents<InputHandler>();
    }
}
