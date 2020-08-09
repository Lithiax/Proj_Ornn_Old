using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData
{
    //Initial position of player
    private static Vector3 position = new Vector3(0.93f, -2.99f, 0);
    public static Vector3 playerPosition
    {
        get
        {
            return position;
        }
        set
        {
            Debug.Log("old:" + PlayerData.playerPosition);
            position = value;
            Debug.Log("new:" + PlayerData.playerPosition);
        }
    }
}
