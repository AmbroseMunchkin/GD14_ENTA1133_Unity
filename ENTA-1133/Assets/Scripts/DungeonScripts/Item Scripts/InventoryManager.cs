using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private InventoryItem ItemPrefab;

    List<ItemData> _inventory = new();
    List<InventoryItem> _inventoryItemInstances = new();

    private void Start()
    {
        _inventory.Add(new ItemData("Axe", ItemData.Rarity.Common));
        _inventory.Add(new ItemData("Club", ItemData.Rarity.Common));
        _inventory.Add(new ItemData("Sword", ItemData.Rarity.Common));
    }

    private void OnEnable()
    {
        foreach(ItemData item in _inventory)
        {
            var inventoryItem = Instantiate(ItemPrefab);
            inventoryItem.Setup(item);
            _inventoryItemInstances.Add(inventoryItem);
        }
    }
    private void OnDisable()
    {
        foreach (InventoryItem item in _inventoryItemInstances)
        { 
            Destroy(item.gameObject);
        }
        _inventoryItemInstances.Clear();
    }

}
