using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using TMPro;

public class ContinueButton : MonoBehaviour
{
   
    public static void Continue()
    {
        string path = Application.persistentDataPath + "/player.MTG";
        // Check theres actually a save file
        if (File.Exists(path))
        { 
            //Load leads scene
            SceneManager.LoadScene("LeadsScene", LoadSceneMode.Single);
            //Load player and their data
            PlayerData data = SaveSystem.LoadPlayer();
            Player player = GameObject.Find("Player").GetComponent<Player>();

            player.successfulCases = data.successfulCases;
            player.failedCases = data.failedCases;
            player.rank = player.GetRank();
        }
        else
        {

            Debug.Log("Cannot continue; No save file found.");
        }
    }
}
