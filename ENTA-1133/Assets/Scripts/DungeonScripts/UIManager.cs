using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Layouts;

    private enum MenuLayouts
    {
        Main = 0,
        Options = 1,
        Credits = 2,
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

    public void ShowOptionsMenu()
    {
        SetLayout(MenuLayouts.Options);
    }

    public void ShowCredits()
    {
        SetLayout(MenuLayouts.Credits);
    }

    public void CloseMainMenu()
    {
        Layouts[0].SetActive(false);
    }
}
