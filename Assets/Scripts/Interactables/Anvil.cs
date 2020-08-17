using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anvil : Interactable
{
    CircleCollider2D circCol;
    public PlayerController player;
    void Start()
    {
        
    }

    void Update()
    {
        if (interact())
        {
            use();
        }
    }

    public void use()
    {
        if (player.itemHeld != null)
            foreach (string tools in player.itemHeld.tool)
            {
                if (tools == "anvil")
                    SceneManager.LoadScene("Wl_Anvil");
            }
        else
            return;
    }
}
