using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Item")]
public class Item : ScriptableObject
{
    public new string name;
    public Sprite sprite;
    public string job;
    public string[] recipe;
}
