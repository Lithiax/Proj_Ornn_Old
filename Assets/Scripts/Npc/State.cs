using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    protected State state;

    public void setState(State state)
    {
        this.state = state;

    }
}
