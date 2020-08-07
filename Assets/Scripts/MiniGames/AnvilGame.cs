using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnvilGame : MonoBehaviour
{
    public GameObject[] keyPool;
    private List<GameObject> keys = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            keys.Add ( keyPool[Random.Range(0, 3)]);
            keys[i] = Instantiate(keys[i], transform.position + new Vector3(0, 0 + (i * 0.80f), 0), transform.rotation);
        }    
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (char c in Input.inputString)
            {
                if (c == keys[0].name[0])
                {
                    Debug.Log("HIT!");
                    keys.Remove(keys[0]);

                    foreach (GameObject key in keys)
                    {
                        key.transform.position -= new Vector3(0, 0.80f, 0);
                    }
                }               
            }
        }

        if (!keys.Any())
        {
            SceneManager.LoadScene("Woodlands");
        }
    }
}


