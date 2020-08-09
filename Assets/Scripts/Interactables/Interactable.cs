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

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("stay");
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("interacted");
            interacted = true;
        }
    }
    public virtual bool interact()
    {
        if (playerInRange == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("trueeee");
            return true;
        }
      
        else
        {
            Debug.Log("nah");
            return false;
        }
    }
}
