using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public PlayerData CurrentPlayerData = null;
    public void LoadScene(string aSceneName)
    {
        CurrentPlayerData.TotalEnemiesKilled = 0;
        if (aSceneName == "CurrentLevel")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level " + CurrentPlayerData.CurrentLevel);
            CurrentPlayerData.Points -= CurrentPlayerData.PointsGained;
            CurrentPlayerData.PointsGained = 0.0f;
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(aSceneName);
        }
        if (aSceneName.StartsWith("Level"))
        {
            CurrentPlayerData.CurrentLevel = aSceneName[aSceneName.Length-1]-'0';
            CurrentPlayerData.PointsGained = 0.0f;
        }
        CurrentPlayerData.HP = 3;

    }
}
