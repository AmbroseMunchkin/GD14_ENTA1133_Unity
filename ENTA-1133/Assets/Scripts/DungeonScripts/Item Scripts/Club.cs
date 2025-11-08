using UnityEngine;

public class Club : Weapon
{
    public override int damage { get { return 0; } }

    public override int minRoll { get { return 0; } }

    public override int maxRoll { get { return 6; } }

    internal override int Used()
    {
        //damage = Roll();
        Debug.Log("You hit the moster with the club, it makes " + damage + " damage!");
        return damage;
    }

    internal override int Roll()
    {
        var roll = Random.Range(minRoll, maxRoll);
        //damage = roll;
        return damage;
    }
}
