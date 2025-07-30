using Unity.VisualScripting;
using UnityEngine;

public class OpenFile : MonoBehaviour
{
    public GameObject FileStack;
    public bool OnOff;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        OnOff = !OnOff;
        FileStack.SetActive(OnOff);
        
    }
}
