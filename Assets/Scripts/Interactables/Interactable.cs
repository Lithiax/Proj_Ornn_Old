using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool playerInRange = false;
    public bool interacted = false;
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    public virtual void OnTriggerExit2D(Collider2D collision)
    {
        playerInRange = false;
    }
    public virtual bool interact()
    {
        if (playerInRange == true && Input.GetKeyDown(KeyCode.E))
        {
            return true;
        }
      
        else
        {
            return false;
        }
    }
}
