using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerAttributes : MonoBehaviour
{
    [SerializeField] BattleManager battleManager;

    public int health;
    public int attack;
    private int MinRoll = 0;
    private int swordMaxRoll = 6;
    private int clubMaxRoll = 8;
    private int axeMaxRoll = 12;

    public void Sword(GameObject target)
    {
        var rollAttack = Random.Range(MinRoll, swordMaxRoll);
        attack = rollAttack;
        var atm = target.GetComponent<EnemyAttributes>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
            battleManager.EnemyTurn();
        }
    }
    public void Club(GameObject target)
    {
        var rollAttack = Random.Range(MinRoll, clubMaxRoll);
        attack = rollAttack;
        var atm = target.GetComponent<EnemyAttributes>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
            battleManager.EnemyTurn();
        }
    }
    public void Axe(GameObject target)
    {
        var rollAttack = Random.Range(MinRoll, axeMaxRoll);
        attack = rollAttack;
        var atm = target.GetComponent<EnemyAttributes>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
            battleManager.EnemyTurn();
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<EnemyAttributes>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
        }
    }
}
