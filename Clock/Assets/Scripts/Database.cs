using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Our Database class
public class Database : ScriptableObject
{
    public Item[] items;
}

//What is in our database
[System.Serializable]
public class Item
{
    public Sprite sprite;

    //Clone constructor
    public Item(Item clone)
    {
        this.sprite = clone.sprite;
    }
}