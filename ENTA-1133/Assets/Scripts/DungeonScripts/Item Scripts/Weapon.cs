using UnityEngine;

public abstract class Weapon : Item
{

    public abstract int minRoll { get; }
    public abstract int maxRoll { get; }
    public abstract int damage { get; }
    internal override int Used()
    {
        return damage;
    }

    internal override int Roll()
    {
        return damage;
    }
}
