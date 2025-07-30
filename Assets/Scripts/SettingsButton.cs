using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public static void OpenSettings()
    { 
        Canvas SettingsCanvas = GameObject.Find("SettingsCanvas").GetComponent<Canvas>();
        Canvas TitleScreenCanvas = GameObject.Find("TitleScreenCanvas").GetComponent<Canvas>();

        TitleScreenCanvas.enabled = false;
        SettingsCanvas.enabled = true;
    }
}
