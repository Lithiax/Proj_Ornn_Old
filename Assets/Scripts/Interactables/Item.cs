using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Item")]
public class Item : ScriptableObject
{
    public Item upgrade;
    public new string name;
    public Sprite sprite;
    public string job;
    public string[] tool;
    public string type;
    private bool completed;

    public void printRecipe()
    {
        if (tool != null)
            foreach (string tools in tool)
            {
                Debug.Log(tools);
            }
    }
}
