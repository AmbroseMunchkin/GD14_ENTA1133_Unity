using UnityEngine;

public class EnemyAttributes : MonoBehaviour
{

    public int health;
    public int attack;
    private int attackMinRoll = 0;
    private int attackMaxRoll = 10;
    private int healthMinRoll = 70;
    private int healthMaxRoll = 120;

    private void Start()
    {
        
        var rollHealth = Random.Range(healthMinRoll, healthMaxRoll);
        health = rollHealth;
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public void DealDamage(GameObject target)
    {
        var rollAttack = Random.Range(attackMinRoll, attackMaxRoll);
        attack = rollAttack;
        var atm = target.GetComponent<PlayerAttributes>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
        }
    }
}
