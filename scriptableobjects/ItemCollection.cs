using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item Collection")]
public class ItemCollection : ScriptableObject
{
    void OnEnable() => _collectedItems = new List<ItemType>();
    
    public event Action Changed;

    private List<ItemType> _collectedItems;

    public int Count => _collectedItems.Count;

    public void Add(Item item)
    {
        _collectedItems.Add(item.ItemType);
        Changed?.Invoke();
        Debug.Log(Count);
    }
    
}
