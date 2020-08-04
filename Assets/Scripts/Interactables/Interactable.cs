using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected bool playerInRange = false;

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerInRange = true;
        }
    }

    protected virtual void OnTriggerExit2D(Collider2D collision)
    {
        playerInRange = false;
    }

    protected virtual bool interact()
    {
        if (playerInRange == true && Input.GetKeyDown(KeyCode.E))
            return true;
        else
            return false;
    }
}
