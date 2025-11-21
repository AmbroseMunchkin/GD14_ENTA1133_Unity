using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
  
    public void ButtonStartGame()
    {
        gameObject.SetActive(false);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
