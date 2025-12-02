using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private UIManager UiSystem;
    [SerializeField] private InGameHud InGameHud;
    [SerializeField] private PlayerUIManager PlayerUIManager;

    public void PausedGame()
    {
        PlayerUIManager.ShowPauseMenu();
    }
    public void ButtonContinue()
    {
        InGameHud.OnUnpauseGame();
        PlayerUIManager.OpenInGameHud();
    }
    

    public void ButtonReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
        SceneManager.UnloadScene("Game");
    }
}
