using UnityEngine;

public class PlayerUIManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Layouts;

    private enum PlayerLayouts
    {
        InGameHud = 0,
        Pause =1,
    }

    private void Start()
    {
        OpenInGameHud();
    }

    private void SetLayout(PlayerLayouts layout)
    {
        for (int i = 0; i < Layouts.Length; i++)
        {
            Layouts[i].SetActive((int)layout == i);
        }
    }

    public void OpenInGameHud()
    {
        SetLayout(PlayerLayouts.InGameHud);
    }

    public void ShowPauseMenu()
    {
        SetLayout(PlayerLayouts.Pause);
    }
    public void HidePauseMenu()
    {
        Layouts[1].SetActive(false);
    }
}
