using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NPCData
{
    //tentative value
    private const int npcCount = 1;
    private static Vector3 position;
    private static string state = null;
    private static float speed = 2;
    public static Vector3 npcPosition
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
    public static string setState
    {
        get
        {
            return state;
        }
        set
        {
            state = value;
        }
    }
    public static float npcSpeed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
}