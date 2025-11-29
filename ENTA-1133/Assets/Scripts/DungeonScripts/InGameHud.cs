using UnityEngine;
using UnityEngine.UI;

public class InGameHud : MonoBehaviour
{
    [SerializeField] private Image HealthBar;
    [SerializeField] private Text Timer;
    [SerializeField] private PauseMenu PauseMenu;

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
        if (_gamePaused != false)
        {
            Debug.Log(gameObject.name);

        }
        
        
        _timer += Time.deltaTime;
        Timer.text = $"{_timer,0:0.000}";
    }

    public void OnPauseGame()
    {
        _gamePaused = true;
        if (_gamePaused == true)
        {
            Debug.Log(gameObject.name);
            PauseMenu.PausedGame();
            Time.timeScale = 0f;
            Debug.Log("Game Paused Succesfully");
        }
    }

    public void OnPause()
    {
        OnPauseGame();
    }

    public void OnUnpauseGame()
    {
        _gamePaused = false;
        if (_gamePaused == false)
        {
            Debug.Log(gameObject.name);
            Time.timeScale = 1f;
            Debug.Log("Game Unpaused Succesfully");
        }
    }

    public void OnHealthChange(float currentHealth, float maxHealth)
    {
        HealthBar.fillAmount = currentHealth / maxHealth;
    }
}
