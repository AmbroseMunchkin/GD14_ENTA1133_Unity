using UnityEngine;
using UnityEngine.UI;

public class InGameHud : MonoBehaviour
{
    [SerializeField] private Image HealthBar;

    private bool _gamePaused = true;
    private float _timer = 0.0f;

   public void OnStartGame()
    {
        _gamePaused = false;
        HealthBar.fillAmount = 1;
    }

    private void Update()
    {
        if (_gamePaused)
            return;
    }

    public void OnPauseGame()
    {
        _gamePaused = true;
    }

    public void OnHealthChange(float currentHealth, float maxHealth)
    {
        HealthBar.fillAmount = currentHealth / maxHealth;
    }
}
