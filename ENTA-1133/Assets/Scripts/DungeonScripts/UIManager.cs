using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Layouts;

    private enum MenuLayouts
    {
        Main = 0,
        InGame = 1,
        Pause = 2,
        Options = 3,
        Credits = 4,
    }

    private void Start()
    {
        OpenMainMenu();
    }

    private void SetLayout(MenuLayouts layout)
    {
        for (int i = 0;  i < Layouts.Length; i++)
        {
            Layouts[i].SetActive((int)layout == i);
        }
    }

    public void OpenMainMenu()
    {
        SetLayout(MenuLayouts.Main);
    }

    public void ActivateInGameHud()
    {
        SetLayout(MenuLayouts.InGame);
    }

    public void ShowPausegameMenu()
    {
        SetLayout(MenuLayouts.Pause);
    }

    public void ShowOptionsMenu()
    {
        SetLayout(MenuLayouts.Options);
    }

    public void ShowCredits()
    {
        SetLayout(MenuLayouts.Credits);
    }
}
