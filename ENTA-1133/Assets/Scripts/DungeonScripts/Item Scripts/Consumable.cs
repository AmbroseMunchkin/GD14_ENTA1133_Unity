using UnityEngine;

public abstract class Consumable : Item
{
    public abstract int minRoll { get; }
    public abstract int maxRoll { get; }
    public abstract int hpRestored { get; }
    internal override int Used()
    {
        return hpRestored;
    }

    internal override int Roll()
    {
        return hpRestored;
    }
}
