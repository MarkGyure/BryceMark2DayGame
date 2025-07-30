using UnityEngine;
using UnityEngine.UIElements;

public class TitleScreenUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var button = new Button(() => { Debug.Log("Button clicked"); }) { text = "Click me" };
    }
}
