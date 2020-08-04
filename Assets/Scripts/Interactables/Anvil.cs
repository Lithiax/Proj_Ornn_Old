using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anvil : Interactable
{
    CircleCollider2D circCol;

    void Start()
    {
        
    }

    void Update()
    {
        if (interact())
        {
            SceneManager.LoadScene("Wl_Anvil");
            Debug.Log("Pressed E");
        }
    }
}
