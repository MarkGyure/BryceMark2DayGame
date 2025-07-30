using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//static so we dont accidentally make multiple versions of a save file (static classes cannot be instantiated)
public static class SaveSystem
{
    public static void SavePlayer(Player player)
    {
        //Create binary formatter, create path to store data, open a file stream
        BinaryFormatter saveFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.MTG";
        FileStream saveStream = new FileStream(path, FileMode.Create);
        //Format data for file
        PlayerData saveData = new PlayerData(player);
        //Format data to binary and close the stream (finished)
        saveFormatter.Serialize(saveStream, saveData);
        saveStream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        //Get save file path
        string path = Application.persistentDataPath + "/player.MTH";
        //If there is a save file then
        if (File.Exists(path)) 
        {
            //Load file stream and binary formatter
            BinaryFormatter loadFormatter = new BinaryFormatter();
            FileStream loadStream = new FileStream(path, FileMode.Open);
            //Deserialize data from binary INTO a playerdata object and then close out the stream
            PlayerData loadData = loadFormatter.Deserialize(loadStream) as PlayerData;
            loadStream.Close();

            return loadData;
        }
        else 
        {
            Debug.LogError("No save file found in path "  + path);
            return null;
        }
    }
}
