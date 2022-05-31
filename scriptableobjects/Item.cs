using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private ItemType _itemType;
    
    public ItemType ItemType => _itemType;

    void Update() => transform.Rotate(_rotation * Time.deltaTime);

    void OnEnable() => GetComponent<MeshRenderer>().material.color = _itemType.ItemColor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out var player))
        {
            player.CoinCollection.Add(this);
            gameObject.SetActive(false);
        }
    }

    private void OnValidate()
    {
        gameObject.name = _itemType.name;
    }
}
