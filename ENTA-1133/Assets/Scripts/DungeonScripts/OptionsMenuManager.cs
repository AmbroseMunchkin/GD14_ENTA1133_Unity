using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuManager : MonoBehaviour
{
    public Toggle FullScreenToggle;
    bool IsFullScreen;

    private void Start()
    {
        IsFullScreen = true;
    }
    public void ChangeFullScreen()
    {
        if (FullScreenToggle.isOn)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }
        else
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
            
    }
}
