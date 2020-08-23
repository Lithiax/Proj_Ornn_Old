using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData
{
    //Initial position of player
    private static Vector3 position = new Vector3(0.93f, -2.99f, 0);
    private static Item item;
    public static Vector3 playerPosition
    {
        get
        {
            return position;
        }
        set
        {
            position = value;
        }
    }

    public static Item getItemHeld
    {
        get
        {
            return item;
        }
        set
        {
            item = value;
        }
    }
}
