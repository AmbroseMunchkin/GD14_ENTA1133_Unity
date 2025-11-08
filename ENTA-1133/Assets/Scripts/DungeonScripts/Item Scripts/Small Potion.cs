using UnityEngine;

public class SmallPotion : Consumable
{
    public override int hpRestored { get { return 0; } }

    public override int minRoll { get { return 0; } }

    public override int maxRoll { get { return 4; } }

    internal override int Used()
    {
        //hpRestored = Roll();
        Debug.Log("You take the small potion and drink it in one sip, it restores " + hpRestored + " health!");
        return hpRestored;
    }

    internal override int Roll()
    {
        var roll = Random.Range(minRoll, maxRoll);
        //hpRestored = roll;
        return hpRestored;
    }
}
