using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public static void CreateNewGame()
    {
        //Create reference to where a save file would be
        string path = Application.persistentDataPath + "/player.MTH";

        if (File.Exists(path))
        {
            File.Delete(path);
            Debug.Log("Found save file; Deleted found save file.");
        }
        //Switch to leads scene
        SceneManager.LoadScene("LeadsScene", LoadSceneMode.Single);
    }
}
