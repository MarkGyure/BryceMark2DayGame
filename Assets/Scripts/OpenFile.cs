using Unity.VisualScripting;
using UnityEngine;

public class OpenFile : MonoBehaviour
{
    public GameObject FileStack;
    public LeadsScript script;
    public bool OnOff;
    
    void OnMouseDown()
    {
        OnOff = !OnOff;
        FileStack.SetActive(OnOff);
        script.GenerateLead();
    }
}
