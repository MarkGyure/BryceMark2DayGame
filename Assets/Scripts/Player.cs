using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int successfulCases = 0;
    [SerializeField] public int failedCases = 0;
    [SerializeField] public string rank = "";

    void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        successfulCases = data.successfulCases;
        failedCases = data.failedCases;
    }

    public void SuccessfulCase()
    {
        successfulCases++;
    }

    public void FailedCase()
    {
        failedCases++;
    }

    public string GetRank()
    {
        return "";
    }
}
