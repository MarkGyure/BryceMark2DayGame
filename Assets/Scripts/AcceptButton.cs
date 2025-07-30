using UnityEngine;
using UnityEngine.SceneManagement;

public class AcceptButton : MonoBehaviour
{
    public static void AcceptCase()
    {
        SceneManager.LoadScene("LevelScene", LoadSceneMode.Single);
    }
}
