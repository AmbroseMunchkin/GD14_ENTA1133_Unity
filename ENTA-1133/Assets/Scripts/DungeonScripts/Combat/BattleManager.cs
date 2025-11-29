using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Layouts;
    [SerializeField] private Text EnemyHealth;
    [SerializeField] private Text PlayerHealth;
    public EnemyAttributes EnemyAtm;
    public PlayerAttributes PlayerAtm;

    private enum BattleLayouts
    {
        PlayerTurn = 0,
    }
    private void SetLayout(BattleLayouts layout)
    {
        for (int i = 0; i < Layouts.Length; i++)
        {
            Layouts[i].SetActive((int)layout == i);
        }
    }

    private void Update()
    {
        EnemyHealth.text = $"Enemy:{EnemyAtm.health}";
        PlayerHealth.text = $"Player:{PlayerAtm.health}";
        if (PlayerAtm.health > 0)
        {
            PlayerTurn();
        }
        else if (EnemyAtm.health < 0)
        {
            WinBattle();
        }
        else if (PlayerAtm.health < 0)
        {
            LoseBattle();
        }
    }
    public void PlayerTurn()
    {
        SetLayout(BattleLayouts.PlayerTurn);
    }
    public void EnemyTurn()
    {
        Layouts[0].SetActive(false);
        EnemyAtm.DealDamage(PlayerAtm.gameObject);
    }
    public void WinBattle()
    {
        SceneManager.LoadScene("Game");
        SceneManager.UnloadScene("Battle");
    }
    public void LoseBattle()
    {
        SceneManager.LoadScene("Lose");
    }
}
