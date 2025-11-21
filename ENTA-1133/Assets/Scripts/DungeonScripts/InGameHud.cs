using UnityEngine;
using UnityEngine.UI;

public class InGameHud : MonoBehaviour
{
    [SerializeField] private Image HealthBar;
    [SerializeField] private Text Timer;
    [SerializeField] private UIManager UiSystem;

    private bool _gamePaused = true;
    private float _timer = 0.0f;

   public void OnStartGame()
   {
        _gamePaused = false;
        HealthBar.fillAmount = 1;
   }

    private void Start()
    {
        Timer.text = "Timer Paused";
        Timer.color = Color.yellow;
    }

    private void Update()
    {
        if (_gamePaused)
            return;
        
        _timer += Time.deltaTime;
        Timer.text = $"{_timer,0:0.000}";
    }

    public void OnPauseGame()
    {
        UiSystem.ShowPausegameMenu();
        _gamePaused = true;
        if (_gamePaused == true)
        {
            Debug.Log("Game Paused Succesfully");
            UiSystem.ShowPausegameMenu();
        }
    }

    public void OnUnpauseGame()
    {
        _gamePaused = false;
        if (_gamePaused == false)
        {
            Debug.Log("Game Unpaused Succesfully");
            UiSystem.ActivateInGameHud();
        }
    }

    public void OnHealthChange(float currentHealth, float maxHealth)
    {
        HealthBar.fillAmount = currentHealth / maxHealth;
    }
}
