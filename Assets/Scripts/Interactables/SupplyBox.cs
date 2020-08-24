using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupplyBox : Interactable
{
    public PlayerController player;
    public Item item;
    void Update()
    {
        if (interact())
        {
            player.giveItem = item;
            player.changeItemHeldSprite();
        }
    }
}
