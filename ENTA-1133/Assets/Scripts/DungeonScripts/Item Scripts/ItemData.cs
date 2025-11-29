using UnityEngine;

public class ItemData
{
    public ItemData(string itemName, Rarity rarity)
    {
        ItemName = itemName;
        ItemRarity = rarity;
    }

    public enum Rarity
    {
        Common,
        Rare
    }
    public string ItemName;

    public Rarity ItemRarity;
}
