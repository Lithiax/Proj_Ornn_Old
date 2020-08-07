using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OrderData
{
    private static Sprite order = null;
    public static Sprite Order
    {
        get
        {
            return order;
        }
        set
        {
            order = value;
        }
    }
}
