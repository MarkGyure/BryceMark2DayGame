using UnityEngine;

public class PlayerData
{
    public int successfulCases;
    public int failedCases;

    public PlayerData(Player player)
    {
        successfulCases = player.successfulCases;
        failedCases = player.failedCases;
    }
}
