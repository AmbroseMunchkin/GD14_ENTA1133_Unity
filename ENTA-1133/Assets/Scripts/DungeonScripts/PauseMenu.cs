using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private UIManager UiSystem;
    [SerializeField] private InGameHud InGameHud;

    public void OnPause()
    {
        ButtonContinue();
    }

    
    public void ButtonContinue()
    {
        UiSystem.ActivateInGameHud();
        InGameHud.OnUnpauseGame();
    }
    

    public void ButtonReturnToMenu()
    {
        UiSystem.OpenMainMenu();
    }
}
