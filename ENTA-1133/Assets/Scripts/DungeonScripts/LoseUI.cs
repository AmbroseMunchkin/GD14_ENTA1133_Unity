using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseUI : MonoBehaviour
{
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
        SceneManager.UnloadScene("Lose");
    }
}
