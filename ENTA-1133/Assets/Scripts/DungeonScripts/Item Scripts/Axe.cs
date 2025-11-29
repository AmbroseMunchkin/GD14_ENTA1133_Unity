using UnityEngine;

public class Axe : ItemData
{
    public Axe(string itemName, Rarity rarity, int damage) : base(itemName, rarity)
    {
        itemName = "Axe";
        rarity = Rarity.Common;
        damage = Roll();
    }

    public int damage;

    public int minRoll = 0;

    public int maxRoll = 8;

    internal int Used()
    {
        //damage = Roll();
        Debug.Log("You hit the moster with the axe, it makes " + damage + " damage!");
        return damage;
    }

    internal int Roll()
    {
        var roll = Random.Range(minRoll, maxRoll);
        //damage = roll;
        return damage;
    }
}
