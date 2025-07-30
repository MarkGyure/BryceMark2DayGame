using System;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public static void Continue()
    {
        string path = Application.persistentDataPath + "/player.MTG";
        // Check theres actually a save file
        if (File.Exists(path))
        { 
            SceneManager.LoadScene("LeadsScene", LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("Cannot continue; No save file found.");
        }
    }
}
