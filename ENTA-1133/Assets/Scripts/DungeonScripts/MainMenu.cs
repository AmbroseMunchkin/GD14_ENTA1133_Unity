using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIManager UiSystem;
    [SerializeField] private InGameHud GameHud;
    [SerializeField] private GameManagerUltra GameManager;
    public void ButtonStartGame()
    {
        UiSystem.ActivateInGameHud();
        GameHud.OnStartGame();
        GameManager.StartTheGame();
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void ButtonOpenCredits()
    {
        UiSystem.ShowCredits();
    }

    public void ButtonOpenOptions()
    {
        UiSystem.ShowOptionsMenu();
    }
}
