using UnityEngine;

public class NormalPotion : Consumable
{
    public override int hpRestored { get { return 0; } }

    public override int minRoll { get { return 0; } }

    public override int maxRoll { get { return 6; } }

    internal override int Used()
    {
        //hpRestored = Roll();
        Debug.Log("You take the potion and drink it in a couple of sips, it restores " + hpRestored + " health!");
        return hpRestored;
    }

    internal override int Roll()
    {
        var roll = Random.Range(minRoll, maxRoll);
        //hpRestored = roll;
        return hpRestored;
    }
}
