using UnityEngine;
using UnityEngine.UI;

public class InGameHud : MonoBehaviour
{
    [SerializeField] private Image HealthBar;
    [SerializeField] private UIManager UiSystem;

    private bool _gamePaused = true;
    private float _timer = 0.0f;

   public void OnStartGame()
    {
        _gamePaused = false;
        HealthBar.fillAmount = 1;
    }

    private void Update()
    {
        if (_gamePaused == true)
        {
            UiSystem.ShowPausegameMenu();
        }
    }

    public void OnPauseGame()
    {
        _gamePaused = true;
        if (_gamePaused == true)
        {
            Debug.Log("Game Paused Succesfully");
        }
    }

    public void OnUnpauseGame()
    {
        _gamePaused = false;
        if (_gamePaused == false)
        {
            Debug.Log("Game Unpaused Succesfully");
        }
    }

    public void OnHealthChange(float currentHealth, float maxHealth)
    {
        HealthBar.fillAmount = currentHealth / maxHealth;
    }
}
