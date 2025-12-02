using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIManager UiSystem;
    [SerializeField] private GameManagerUltra GameManager;
    public void ButtonStartGame()
    {
        SceneManager.LoadScene("Game");
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
