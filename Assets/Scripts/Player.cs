using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int successfulCases = 0;
    [SerializeField] public int failedCases = 0;
    [SerializeField] public string rank = "";

    void Start()
    {
        DontDestroyOnLoad(gameObject);
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
        return "Rookie";
    }
}